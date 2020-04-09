using RetroPiDay.Games.Simon.OMF;
using System;
using System.Collections.Generic;
using System.IO;

namespace RetroPiDay.Games.Simon
{
    class Score
    {
        /*
         * Test.  Create Unit test or put in main.
            Score score = new Score($"{Environment.UserName}@{Dns.GetHostName()}osisoft.com");
            score.CurrentScore = 5;
            score.RecordHighScore();

            var scoreScreen = new HighScoreScreen();
            scoreScreen.ShowHighScores();
            Console.ReadKey();
        */

        public int CurrentScore { get; set; } = 0;

        public int HighScore { get; set; }

        public string Player { get; set; } = "The PI System";

        private string _filePath = Directory.GetCurrentDirectory() + "/HighScore.txt";

        private string _scores = "";

        private Dictionary<string, List<int>> Scores = new Dictionary<string, List<int>>();

        public Score(string _playerName)
        {
            Player = _playerName;
        }

        public void RecordHighScore()
        {
            var eds = new EDSInteraction(Player);
            eds.UpdateUserScores(Player, CurrentScore);
            eds.PutHighScore(this).Wait();
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

    }
}
