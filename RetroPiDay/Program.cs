using RetroPiDay.Games.Simon;
using RetroPiDay.Games.Simon.OMF;
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

                Console.Clear();
                Console.WriteLine("Starting a new game, press Ctrl+c to quit.");
                Thread.Sleep(5000);
            }
        }
    }
}
