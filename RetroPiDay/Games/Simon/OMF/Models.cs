using System;
using System.Collections.Generic;
using System.Text;

namespace RetroPiDay.Games.Simon.OMF
{
    class Models
    {

        public class UserScore
        {
            public int ScoreKey { get; set; } = 0;

            public int Score { get; set; } = 0;
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

            public List<UserScore> Values { get; set; }

            public void Add(UserScore d)
            {
                if (Values == null)
                {
                    Values = new List<UserScore>();
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
