using RetroPiDay.Games.Simon;
using System;

namespace RetroPiDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = Console.WindowWidth;
            int height = Console.WindowHeight;

            if (height < 40)
            {
                height = 40;            
            }

            if (width < 100)
            {
                width = 100;
            }

            try
            {
                Console.SetWindowSize(width, height);
            }
            catch (Exception)
            {
            }

            while (true)
            {
                MainMenuDisplayOptions();
                var input = Console.ReadKey().KeyChar;

                switch (Char.ToLowerInvariant(input))
                {
                    case 'n':
                        var game = new Simon();
                        game.Intro();
                        game.PlayGame();
                        game.Outro();
                        break;
                    case 'x':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("bad input. try again.");
                        break;
                }
            }
        }

        private static void MainMenuDisplayOptions()
        {
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine("Main Menu:");
            Console.WriteLine("  'n': New Game");
            Console.WriteLine("  'x': Exit");
        }
    }
}
