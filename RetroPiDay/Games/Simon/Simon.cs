using System;
using System.Net;
using System.Linq;
using System.Threading;

namespace RetroPiDay.Games.Simon
{
    public class Simon : IGame
    {
        private Credits exitCredits = new Credits();
        private static string user = $"{Environment.UserName}";
        private Score score = new Score(user);
        private EDSInteraction eds = new EDSInteraction(user);
        private int sequenceMaxSize = 128;
        private int sequenceSpeedinMS = 350;

        public Simon()
        {
        }

        public void Intro()
        {
            Console.Clear();
            Sounds.PlayIntroSong();
            Display.DisplaySplashScreen();
            eds.GetHighScores().Wait();
            //Set score.HighScore to the first score in eds.HighScores list
        }

        public void Outro()
        {
            score.RecordHighScore();
            score.ShowHighScores();
            exitCredits.RollReel();
            Thread.Sleep(1000);
        }

        public void PlayGame()
        {
            Console.Clear();
            Console.WriteLine("Memorize the sequence and repeat it back using the keys r, g, b, and y to represent there respective colors.");
            Console.WriteLine("When you are ready to start press enter.");
            Console.ReadLine();

            var fullSequence = SimonSequence.GenerateSequence(sequenceMaxSize);

            var round = 1;
            while (round <= fullSequence.Length)
            {
                var partialSequence = fullSequence.Take(round).ToArray();
                SimonSequence.PlaySequence(partialSequence, sequenceSpeedinMS);
                Display.DisplayBlank();
                Console.WriteLine("Enter the sequence when ready");
                var isWin = ValidateUserInput(partialSequence);
                if (!isWin)
                {
                    Sounds.PlayInvalidCharacterSound();
                    Lose();
                    return;
                }

                Console.WriteLine("");
                Console.WriteLine($"Great job!  You got all colors right!");
                Thread.Sleep(2000);

                round++;
                score.CurrentScore = round;
            }

            score.DisplayScore();
            Win();
        }

        private bool ValidateUserInput(Button[] sequence)
        {
            int i = 0;
            do
            {
                var inputChar = Console.ReadKey(true).KeyChar;
                Display.DisplayButton(inputChar);
                
                if (!Buttons.isValidButtonInput(inputChar) ||
                    Char.ToLowerInvariant(inputChar) != sequence[i].character)
                {
                    return false;
                }

                Sounds.PlaySoundForColorKey(inputChar);

                i++;
            }
            while (i < sequence.Length);

            return true;
        }

        private void Win()
        {
            Console.Clear();
            Console.WriteLine("Winner!");
            Thread.Sleep(2000);
        }

        private void Lose()
        {
            Console.Clear();
            Console.WriteLine("You lost!");
            Thread.Sleep(2000);
        }
    }
}
