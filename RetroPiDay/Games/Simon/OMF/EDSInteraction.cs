using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static RetroPiDay.Games.Simon.Models;
using UserScore = RetroPiDay.Games.Simon.Models.UserScore;
using UserStream = RetroPiDay.Games.Simon.Models.UserStream;

namespace RetroPiDay.Games.Simon
{
    class EDSInteraction
    {
        private static HttpClient _client = new HttpClient();
        private static string _streamUrl = $"http://localhost:5590/api/v1/tenants/default/namespaces/default/streams/";
        private static string _typeUrl = $"http://localhost:5590/api/v1/tenants/default/namespaces/default/types/";
        private static string _streamDataUrl = $"http://localhost:5590/api/v1/tenants/default/namespaces/default/streams/TopTenScores/Data";
        private static string _topTen = "TopTen";
        private static string _highScores = "HighScores";
        private static string _playerScores = "PlayerScores";
        public List<HighScores> _highScoresList = null;
        private bool IsEDSAlive = true;


        public EDSInteraction(string streamName)
        {
            try
            {
                //Setup types and HighScores
                SetupTypes(_playerScores, OMFStrings.UserTypeString);
                SetupTypes(_highScores, OMFStrings.TopTenTypeString);
                SetupStream(_topTen, string.Format(OMFStrings.ContainerString, _topTen, _highScores));

                //Add user stream
                SetupStream(streamName, string.Format(OMFStrings.ContainerString, streamName, _playerScores));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }

        public void UpdateUserScores(string user, int score)
        {
            if (!IsEDSAlive)
            {
                return;
            }
            UserScore val = GetLastDataValue(user);

            if (val == null)
            {
                val = new UserScore();
            }

            val.ScoreKey++;
            val.Score = score;
   
            SendUserScore(val, user);

        }

        public bool SetupStream(string streamName, string json)
        {
            if (!IsEDSAlive)
            {
                return false;
            }
            if (CheckIfStreamExists(streamName))
            {
                return true;
            }

            HttpResponseMessage returnCode = default;
            var url = _streamUrl + streamName;
            var content = new StringContent("{" + json + "}", Encoding.UTF8, "application/json");

            try
            {
                returnCode = _client.PostAsync(url, content).Result;
                returnCode.EnsureSuccessStatusCode();
                return true;
            }
            catch(AggregateException)
            {
                IsEDSAlive = false;
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        private bool SetupTypes(string type, string json)
        {
            if (!IsEDSAlive)
            {
                return false;
            }
            if (CheckIfTypeExists(type))
            {
                return true;
            }

            HttpResponseMessage returnCode = default;
            var url = _typeUrl + type;
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                returnCode = _client.PostAsync(url, content).Result;
                returnCode.EnsureSuccessStatusCode();
                return true;
            }
            catch(AggregateException)
            {
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        private UserScore GetLastDataValue(string user)
        {
            if (!IsEDSAlive)
            {
                return null;
            }
            HttpResponseMessage returnCode = default;
            string _url = _streamUrl + user + "/data/last";
            try
            {
                returnCode = _client.GetAsync(_url).Result;
            }
            catch (AggregateException)
            {
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            if(returnCode.StatusCode == HttpStatusCode.NotFound)
            {
                return new UserScore();
            }

            return JsonSerializer.Deserialize<UserScore>(returnCode.Content.ReadAsStringAsync().Result);
        }

        private bool SendUserScore(UserScore val, string stream)
        {
            if (!IsEDSAlive)
            {
                return false;
            }
            HttpResponseMessage returnCode = default;
            UserStream user = new UserStream();
            user.ContainerId = stream;
            user.Add(val);
            var newScore = JsonSerializer.Serialize(user.Values);
            var content = new StringContent(newScore, Encoding.UTF8, "application/json");
            string _url = _streamUrl + stream + "/" + "data";
            try
            {
                returnCode = _client.PostAsync(_url, content).Result;
                returnCode.EnsureSuccessStatusCode();
                return true;
            }
            catch (AggregateException)
            {
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

        }

        private bool CheckIfTypeExists(string typeName)
        {
            HttpResponseMessage returnCode = default;
            var url = _typeUrl + typeName;
            if (!IsEDSAlive)
            {
                return false;
            }
            try
            {
                returnCode = _client.GetAsync(url).Result;
                if (returnCode.StatusCode == HttpStatusCode.NotFound)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (AggregateException)
            {
                IsEDSAlive = false;
                Console.WriteLine("** EDS MUST BE INSTALLED FOR SCORE RECORDING FUNCTIONALITY **");
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public int UserHighScore(string user)
        {
            HttpResponseMessage returnCode = default;
            string _url = _streamUrl + user + "/data?startIndex=0&count=1000";
            if (!IsEDSAlive)
            {
                return 0;
            }

            List<UserScore> userScores = new List<UserScore>();
            try
            {
                returnCode = _client.GetAsync(_url).Result;
            }
            catch (AggregateException)
            {
                IsEDSAlive = false;
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            if (returnCode.StatusCode == HttpStatusCode.NotFound)
            {
                return 0;
            }
            userScores = JsonSerializer.Deserialize<List<UserScore>>(returnCode.Content.ReadAsStringAsync().Result);

            return FindUserMaxScore(userScores);
        }

        private int FindUserMaxScore(List<UserScore> userScores)
        {
            int max = 0;

            foreach(var s in userScores)
            {
                if(s.Score > max)
                {
                    max = s.Score;
                }
            }

            return max;
        }

        private bool CheckIfStreamExists(string streamName)
        {
            HttpResponseMessage returnCode = default;
            var url = _streamUrl + streamName;
            if (!IsEDSAlive)
            {
                return false;
            }
            try
            {
                returnCode = _client.GetAsync(url).Result;
                if (returnCode.StatusCode == HttpStatusCode.NotFound)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (AggregateException)
            {
                IsEDSAlive = false;
                Console.WriteLine("** EDS MUST BE INSTALLED FOR SCORE RECORDING FUNCTIONALITY **");
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public async Task<List<HighScores>> GetHighScores()
        {
            var url = _streamUrl + _topTen + "/data?startIndex=1&count=10";
            if(!IsEDSAlive)
            {
                return null;
            }
            try
            {
                var response = await _client.GetAsync(url);
                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }
                else
                {
                    string highScoresString = await response.Content.ReadAsStringAsync();

                    List<HighScores> highScores = JsonSerializer.Deserialize<List<HighScores>>(highScoresString);
                    highScores.Sort(delegate (HighScores x, HighScores y)
                    {
                        if (x.ScoreKey == null && y.ScoreKey == null) return 0;
                        else if (x.ScoreKey == null) return -1;
                        else if (y.ScoreKey == null) return 1;
                        else return x.ScoreKey.CompareTo(y.ScoreKey);
                    });
                        
                    _highScoresList = highScores;

                    return highScores;
                }
            }
            catch (AggregateException)
            {
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public async Task PutHighScore(Score myScore)
        {
            var baseUrl = _streamUrl + _topTen;
            if (!IsEDSAlive)
            {
                return;
            }
            try
            {
                List<HighScores> highScores = await GetHighScores();
                List<HighScores> updatedHighScores = new List<HighScores>();
                HighScores myHighScore = null;
                HighScores lowestExistingScore = null;
                string json = null;
                StringContent content = null;
                HttpResponseMessage returnCode = null;

                const int maxBoardLength = 10;
                int myHighScoreIndex = maxBoardLength + 1;
                foreach (var scorer in highScores)
                {
                    if (myScore.CurrentScore > scorer.Score)
                    {
                        // Beat him/her/they!

                        if (scorer.ScoreKey == maxBoardLength)
                        {
                            // scorer drops off of top-10 list.  Re-use its object.
                            myHighScore = scorer;
                        }
                        else if (scorer.ScoreKey == highScores.Count)
                        {
                            // Keep track of lowest scoring one.  Will do a POST on this one because it will be new.
                            lowestExistingScore = scorer;
                        }

                        // Update my index in rankings.  Will fill in later.
                        if (scorer.ScoreKey < myHighScoreIndex)
                        {
                            myHighScoreIndex = scorer.ScoreKey;
                        }

                        // Push this one down in rankings.  Value will be ignored for one in spot 10->11.
                        scorer.ScoreKey++;

                        // Will need to update this scorer in cloud.
                        updatedHighScores.Add(scorer);
                    }
                }

                bool doPost = false;
                // Create new object for me
                if (highScores.Count < maxBoardLength)
                {
                    // Room for one more in leader board.
                    doPost = true;
                    myHighScore = new HighScores();
                    updatedHighScores.Add(myHighScore);
                    if (myHighScoreIndex == (maxBoardLength + 1))
                    {
                        // I am lowest on the board
                        myHighScoreIndex = highScores.Count + 1;
                    }
                }

                if (myHighScore != null)
                {
                    // Items need updating

                    // Fill in my values
                    myHighScore.ScoreKey = myHighScoreIndex;
                    myHighScore.Score = myScore.CurrentScore;
                    myHighScore.Username = myScore.Player;

                    var url = baseUrl + "/data";

                    json = JsonSerializer.Serialize<List<HighScores>>(updatedHighScores);
                    content = new StringContent(json, Encoding.UTF8, "application/json");
                    returnCode = _client.PutAsync(url, content).Result;
                    returnCode.EnsureSuccessStatusCode();
                }
            }
            catch (AggregateException)
            {
                IsEDSAlive = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
