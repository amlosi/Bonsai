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
            Console.WriteLine("When you are ready to start press enter");
            Console.ReadLine();

            var fullSequence = SimonSequence.GenerateSequence(sequenceMaxSize);

            var round = 1;
            while (round <= fullSequence.Length)
            {
                var partialSequence = fullSequence.Take(round).ToArray();
                SimonSequence.PlaySequence(partialSequence, sequenceSpeedinMS);
                var isWin = ValidateUserInput(partialSequence);
                if (!isWin)
                {
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
                Console.Clear();

                var inputChar = Console.ReadKey().KeyChar;
                if (!Buttons.isValidButtonInput(inputChar))
                {
                    return false;
                }

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
