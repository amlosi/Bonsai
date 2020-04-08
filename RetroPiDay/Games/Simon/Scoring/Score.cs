using System;
using System.Collections.Generic;
using System.IO;

namespace RetroPiDay.Games.Simon
{
    class Score
    {
        public int CurrentScore { get; set; } = 0;

        public int HighScore { get; set; }

        public string Player { get; set; } = "The PI System";

        private string _filePath = Directory.GetCurrentDirectory() + "/HighScore.txt";

        private string _scores = "";

        private Dictionary<string, List<int>> Scores = new Dictionary<string, List<int>>();

        public Score(string _playerName)
        {
            ReadHighScore();
            Player = _playerName;
        }

        public void RecordHighScore()
        {            
            using(var f = File.CreateText(_filePath))
            {
                f.Write(HighScore);
            }
        }

        public void ReadHighScore()
        {
            if(File.Exists(_filePath))
            {
                using (var f = new StreamReader(_filePath))
                {
                    int.TryParse(f.ReadToEnd(), out int score);
                    HighScore = score;
                }
            }
            else
            {
                HighScore = 0;
            }
            
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
