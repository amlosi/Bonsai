using RetroPiDay.Games.Simon;
using System;
using System.Threading;

namespace RetroPiDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BufferHeight = 40;
            Console.WindowHeight = 40;
            Console.WindowWidth = 85;
            Console.BufferWidth = 85;

            while (true)
            {
                var game = new Simon(new Settings());
                game.Intro();
                game.PlayGame();
                game.Outro();

                Console.Clear();
                Console.WriteLine("Starting a new game, press Ctrl+c to quit.");
                Thread.Sleep(5000);
            }
        }
    }
}
