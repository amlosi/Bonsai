using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace RetroPiDay.Games.Simon.OMF
{
    class EDSInteraction
    {
        private static HttpClient _client = new HttpClient();
        private static string _omfUrl = "http://localhost:5590/api/v1/tenants/default/namespaces/default/omf/";
        private static string _streamUrl = $"http://localhost:5590/api/v1/tenants/default/namespaces/default/streams/";
        private static string _typeUrl = $"http://localhost:5590/api/v1/tenants/default/namespaces/default/types/";
        private static string _streamDataUrl = $"http://localhost:5590/api/v1/tenants/default/namespaces/default/streams/TopTenScores/Data";
        private static string _topTen = "TopTen";
        private static string _highScores = "HighScores";
        private static string _playerScores = "PlayerScores";


        public EDSInteraction(string streamName)
        {
            SetupTypes(_playerScores, OMFStrings.UserTypeString);
            SetupTypes(_highScores, OMFStrings.TopTenTypeString);
            if (!CheckIfStreamExists(_topTen))
            {
                SetupStream(_topTen, string.Format(OMFStrings.ContainerString, _topTen, _highScores));
            }
            
        }

        private bool SetupStream(string streamName, string json)
        {
            HttpResponseMessage returnCode = default;
            var url = _typeUrl + streamName;
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

        public async Task<Models.TopTenStream> GetHighScores()
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

                    Models.TopTenStream highScores = JsonSerializer.Deserialize<Models.TopTenStream>(highScoresString);

                    return highScores;
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
