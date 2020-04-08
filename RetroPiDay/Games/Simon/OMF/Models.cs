using System;
using System.Collections.Generic;
using System.Text;

namespace RetroPiDay.Games.Simon.OMF
{
    class Models
    {

        public class UserScores
        {
            public int ScoreKey { get; set; }

            public List<int> Scores { get; set; }
        }

        public class UserScore
        {
            public int ScoreKey { get; set; }

            public int Score { get; set; }
        }

        public class HighScores
        {
            public int ScoreKey { get; set; }

            public int Score { get; set; }

            public string Username { get; set; }
        }

        public class UserStream
        {
            public string ContainerId { get; set; }

            public List<UserScores> Values { get; set; }

            public void Add(UserScores d)
            {
                if (Values == null)
                {
                    Values = new List<UserScores>();
                }
                Values.Add(d);
            }

        }

        public class TopTenStream
        {
            List<HighScores> HighScorers = new List<HighScores>();
        }

    }
}
