﻿using RetroPiDay.Games.Simon;
using System;
using System.Net;

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

            Console.SetWindowSize(width, height);

            bool success = false;
            while (!success)
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
