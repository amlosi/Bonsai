using RetroPiDay.Games.Simon.OMF;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetroPiDay.Games.Simon.Scoring
{
    public class HighScoreScreen
    {
        public void ShowHighScores()
        {
            Models.TopTenStream topten = new Models.TopTenStream();
            topten.HighScorers = new List<Models.HighScores>();
            topten.HighScorers.Add(new Models.HighScores() { ScoreKey = 1, Score = 999, Username = "alevi@osisoft.com" });
            topten.HighScorers.Add(new Models.HighScores() { ScoreKey = 2, Score = 888, Username = "greg@osisoft.com" });
            topten.HighScorers.Add(new Models.HighScores() { ScoreKey = 3, Score = 777, Username = "Sean@osisoft.com" });
            topten.HighScorers.Add(new Models.HighScores() { ScoreKey = 4, Score = 666, Username = "Alix@osisoft.com" });

            foreach (var scorer in topten.HighScorers)
            {
                Console.WriteLine($"{scorer.ScoreKey}  {scorer.Score}  {scorer.Username}");
            }

            var eds = new EDSInteraction("asdf");
            var highScoresString = eds.GetHighScores().Result;
        }
    }
}
