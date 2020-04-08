using System;
using System.IO;

namespace RetroPiDay.Games.Simon
{
    class Score
    {
        public int CurrentScore { get; set; } = 0;

        public int HighScore { get; set; }

        private string _filePath = Directory.GetCurrentDirectory() + "/HighScore.txt";

        private string _scores = "";

        public Score()
        {
            ReadHighScore();
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
            _scores = $"\t     Current Score: {CurrentScore}        High Score: {HighScore}     ";
            Console.WriteLine(_scores);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
