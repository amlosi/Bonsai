using System;
using System.Collections.Generic;
using System.Threading;

namespace RetroPiDay.Games.Simon
{
    public class Simon : IGame
    {
        public Simon(Settings settings)
        {
        }

        public void Intro()
        {
            Console.Clear();
            Console.WriteLine("This is an intro!");
            Thread.Sleep(1000);
        }

        public void Outro()
        {
            Console.Clear();
            Console.WriteLine("This is an outro!");
            Thread.Sleep(1000);
        }

        public void PlayGame()
        {
            Console.Clear();
            Console.WriteLine("When you are ready to start press enter");
            Console.ReadLine();

            List<char> sequence = GenerateRandomSequence();
            PlaySequence(sequence);
            var isWin = ValidateUserInput(sequence);

            if (isWin)
                Win();
            else
                Lose();
        }

        private bool ValidateUserInput(List<char> sequence)
        {
            int i = 0;
            do
            {
                Console.Clear();

                var inputChar = Console.ReadKey(true).KeyChar;
                SendToConsole(inputChar);
                if (Char.ToLower(inputChar) != sequence[i])
                {
                    return false;
                }

                i++;
            }
            while (i < sequence.Count);

            return true;
        }

        private List<char> GenerateRandomSequence()
        {
            return new List<char>() { 'r', 'g', 'b', 'y' };
        }

        private void PlaySequence(List<char> sequence)
        {
            foreach (var item in sequence)
            {
                Console.Clear();
                Console.WriteLine(item);
                Thread.Sleep(200);
            }
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
