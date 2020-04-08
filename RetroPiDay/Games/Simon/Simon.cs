using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace RetroPiDay.Games.Simon
{
    public class Simon : IGame
    {
        private Credits exitCredits = new Credits();
        private Score score = new Score("greg");
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
        }

        public void Outro()
        {
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
                Console.WriteLine("Enter the sequence when ready");
                var isWin = ValidateUserInput(partialSequence);
                if (!isWin)
                {
                    Sounds.PlayInvalidCharacterSound();
                    Lose();
                    return;
                }

                round++;
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
