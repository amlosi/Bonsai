using System.Collections.Generic;

namespace RetroPiDay.Games.Simon
{
    public class Models
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

            public int CompareTo(HighScores otherKey)
            {
                // A null value means that this object is greater.
                if (otherKey == null)
                    return 1;

                else
                    return this.ScoreKey.CompareTo(otherKey.ScoreKey);
            }
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
            public List<HighScores> HighScorers = new List<HighScores>();
        }

    }
}
