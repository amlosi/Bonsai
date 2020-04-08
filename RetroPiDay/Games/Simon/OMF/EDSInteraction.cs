using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using static RetroPiDay.Games.Simon.OMF.Models;

namespace RetroPiDay.Games.Simon.OMF
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


        public EDSInteraction(string streamName)
        {
            //Setup types and HighScores
            SetupTypes(_playerScores, OMFStrings.UserTypeString);
            SetupTypes(_highScores, OMFStrings.TopTenTypeString);
            SetupStream(_topTen, string.Format(OMFStrings.ContainerString, _topTen, _highScores));

            //Add user stream
            SetupStream(streamName, string.Format(OMFStrings.ContainerString, streamName, _playerScores));
        }

        public void UpdateUserScores(string user, int score)
        {
            UserScore val = GetLastDataValue(user);

            val.ScoreKey++;
            val.Score = score;
   
            SendUserScore(val, user);

        }

        public bool SetupStream(string streamName, string json)
        {
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
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        private bool SetupTypes(string type, string json)
        {
            HttpResponseMessage returnCode = default;
            var url = _typeUrl + type;
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                returnCode = _client.PostAsync(url, content).Result;
                returnCode.EnsureSuccessStatusCode();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        private UserScore GetLastDataValue(string user)
        {
            HttpResponseMessage returnCode = default;
            string _url = _streamUrl + user + "/data/last";
            try
            {
                returnCode = _client.GetAsync(_url).Result;
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
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

        }

        private bool CheckIfStreamExists(string streamName)
        {
            HttpResponseMessage returnCode = default;
            var url = _streamUrl + streamName;

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
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public async Task<string> GetHighScores()
        {
            var url = _streamUrl + "TopTen";

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

                    return highScoresString;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}
