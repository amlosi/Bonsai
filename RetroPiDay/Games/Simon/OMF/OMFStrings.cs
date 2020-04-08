using System;
using System.Collections.Generic;
using System.Text;

namespace RetroPiDay.Games.Simon.OMF
{
    class OMFStrings
    {
        public static string UserTypeString { get; } = @"{
            ""Id"": ""PlayerScores"",
            ""Name"": ""PlayerScores"",
            ""SdsTypeCode"": 1,
            ""Properties"": [
                {
                    ""Id"": ""ScoreKey"",
                    ""Name"": ""ScoreKey"",
                    ""SdsType"": {
                        ""Id"": ""scoreskey"",
                        ""Name"": ""ScoreKey"",
                        ""SdsTypeCode"": 9,
                        ""isindex"": ""true""
                    }
                },
                {
                    ""Id"": ""Score"",
                    ""Name"": ""Score"",
                    ""SdsType"": {
                        ""Id"": ""scores"",
                        ""Name"": ""Score"",
                        ""SdsTypeCode"": 9,
                    }
                }
            ]
        }";

        public static string TopTenTypeString { get; } = @"{
            ""Id"": ""HighScores"",
            ""Name"": ""HighScores"",
            ""SdsTypeCode"": 1,
            ""Properties"": [
                {
                    ""Id"": ""Username"",
                    ""Name"": ""Username"",
                    ""SdsType"": {
                        ""Id"": ""user"",
                        ""Name"": ""Username"",
                        ""SdsTypeCode"": 18,
                    }
                },
                {
                    ""Id"": ""ScoreKey"",
                    ""Name"": ""ScoreKey"",
                    ""SdsType"": {
                        ""Id"": ""scorekey"",
                        ""Name"": ""ScoreKey"",
                        ""SdsTypeCode"": 9,
                    }
                },
                {
                    ""Id"": ""Score"",
                    ""Name"": ""Score"",
                    ""SdsType"": {
                        ""Id"": ""score"",
                        ""Name"": ""Score"",
                        ""SdsTypeCode"": 9,
                    }
                }
            ]
        }";

        public static string ContainerString { get; set; } = @$"""Id"": ""{{0}}"", ""TypeId"": ""{{1}}""";

        public static string DataString { get; set; } =
            "{" +
                $"containerid: {0}," +
                "values: [" +
                    $"{1}" +
                "]" +
            "}";

    }
}
