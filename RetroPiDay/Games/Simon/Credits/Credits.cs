using System;
using System.Collections.Generic;
using System.Threading;

namespace RetroPiDay.Games.Simon
{
    class Credits
    {
        private static int _depth = 4;
        private static int _breadth = 50;
        private static int _middle = (_breadth - 1) / 2;
        private char[,] _creditsReel = new char[_depth, _breadth];
        private List<string> _devs = new List<string>();
        private List<string> _roles = new List<string>();
        private List<ConsoleColor> _colors = new List<ConsoleColor>();

        //[0]      "DID THIS THING"
        //
        //[2]      "PERSON WHO DID THE THING"
        //


        public Credits()
        {
            _roles.Add("Sound FX");
            _roles.Add("User Interaction");
            _roles.Add("Game Loop");
            _roles.Add("Sequence Generation");
            _roles.Add("Splash Screen");
            _roles.Add("Credits/High Score");

            _devs.Add("Greg Holt");
            _devs.Add("Sean Driscoll");
            _devs.Add("Alan Levi");
            _devs.Add("Randal Glass");
            _devs.Add("Jeremy Spooner");
            _devs.Add("Alix Willis");

            _colors.Add(ConsoleColor.Red);
            _colors.Add(ConsoleColor.Blue);
            _colors.Add(ConsoleColor.Yellow);
            _colors.Add(ConsoleColor.Green);
        }

        private void InitReel()
        {
            ClearReelLines();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        private void ClearReelLines()
        {
            for(int i = 0; i < _depth; i++)
                for(int j = 0; j < _breadth; j++)
                {
                    _creditsReel[i, j] = ' ';
                }
        }

        private void PrintCredit()
        {
            for (int i = 0; i < _depth; i++)
            {
                Console.Write("\t");
                for (int j = 0; j < _breadth; j++)
                {
                    Console.Write(_creditsReel[i, j]);
                    Thread.Sleep(10);
                }
                Console.Write("\n");
            }
            Console.Write("\t");
        }

        public void RollReel()
        {
            int pos = 0;
            int color = 0;
            while (pos < _devs.Count)
            {
                InitReel();
                Console.Clear();
                color = UpdateColor(color);
                UpdateReel(pos);
                PrintCredit();
                Thread.Sleep(1500);
                pos++;   
            }

        }

        private void UpdateReel(int pos)
        {      
            //Update Title line
            UpdateFirst(_roles[pos].Substring(0, _roles[pos].Length / 2 + 1), 0);
            UpdateLast(_roles[pos].Substring((_roles[pos].Length / 2) + 1), 0);
         
            //Update Dev line
            UpdateFirst(_devs[pos].Substring(0, _devs[pos].Length / 2 + 1), 2);
            UpdateLast(_devs[pos].Substring((_devs[pos].Length / 2) + 1), 2);

        }

        private void UpdateFirst(string s, int line)
        {
            for(int i = 0; i < s.Length;)
            {
                _creditsReel[line, _middle - i] = s[^++i];
            }
        }

        private void UpdateLast(string s, int line)
        {
            for (int i = 1; i <= s.Length; i++)
            {
                _creditsReel[line, _middle + i] = s[i-1];
            }
        }

        private int UpdateColor(int color)
        {
            Console.BackgroundColor = _colors[color];

            if (color == 3)
            {
                color = 0;
            }
            else
            {
                color++;
            }

            return color;
        }

    }
}
