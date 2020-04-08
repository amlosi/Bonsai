using RetroPiDay.Games.Simon;
using RetroPiDay.Games.Simon.Scoring;
using System;

namespace RetroPiDay
{
    class Program
    {
        static void Main(string[] args)
        {
            bool success = false;
            while (!success)
            {
                MainMenuDisplayOptions();
                success = true;
                var keyInfo= Console.ReadKey();

                char mainMenuInput = keyInfo.KeyChar;
                switch (mainMenuInput)
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
                        success = false;
                        Console.WriteLine("bad input. try again.");
                        break;
                }
            }
        }

        private static void MainMenuDisplayOptions()
        {
            Console.Clear();
            Console.WriteLine("Main Menu:");
            Console.WriteLine("  'n': New Game");
            Console.WriteLine("  'x': Exit");
        }
    }
}
