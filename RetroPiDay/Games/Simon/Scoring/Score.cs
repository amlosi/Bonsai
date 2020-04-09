using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace RetroPiDay.Games.Simon
{
    class Score
    {
        private EDSInteraction _eds = null;

        public int CurrentScore { get; set; } = 0;

        public int HighScore { get; set; }

        public string Player { get; set; } = "The PI System";

        private string _filePath = Directory.GetCurrentDirectory() + "/HighScore.txt";

        private string _scores = "";

        private Dictionary<string, List<int>> Scores = new Dictionary<string, List<int>>();

        public Score(string _playerName)
        {
            Player = _playerName;
            _eds = new EDSInteraction(Player);
            _eds.GetHighScores().Wait();
            HighScore = _eds._highScoresList[0].Score;
        }

        public void RecordHighScore()
        {
            _eds.UpdateUserScores(Player, CurrentScore);
            _eds.PutHighScore(this).Wait();
        }

        public void DisplayScore()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            _scores = $"\tPlayer: {Player}     Current Score: {CurrentScore}        High Score: {HighScore}     ";
            Console.WriteLine(_scores);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

        }

        public void ShowHighScores()
        {
            Console.Clear();
            var eds = new EDSInteraction("asdf");
            var highScores = eds.GetHighScores().Result;
            var colors = new ConsoleColor[] { ConsoleColor.Green, ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Blue };

            string format = "{0, -6}{1, -6}{2, -20}";
            Console.WriteLine($"************ HIGH SCORES ************");
            Console.WriteLine(String.Format(format, "RANK", "SCORE", "USER"));
            foreach (var scorer in highScores)
            {
                Console.WriteLine(String.Format(format, scorer.ScoreKey, scorer.Score, scorer.Username));
            }
            Thread.Sleep(5000);
        }
    }
}
