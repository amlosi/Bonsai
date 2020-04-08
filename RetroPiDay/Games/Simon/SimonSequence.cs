using System;
using System.Threading;

namespace RetroPiDay.Games.Simon
{
    public class SimonSequence
    {
        public static ConsoleColor[] simonColors = { ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.Green, ConsoleColor.Yellow };
        public static char[] simonChars = { 'r', 'b', 'g', 'y' };

        public static void DisplayListOfButtons(Button[] colorList, int delayInMs)
        {
            Console.Clear();
            for (int i = 0; i < colorList.Length; i++)
            {
                Console.WriteLine();
                Button colorIndex = colorList[i];
                for (int x = 0; x < 4; x++)
                {
                    Console.ResetColor();
                    if (colorIndex.character == simonChars[x])
                    {
                        ConsoleColor conColor = colorIndex.color;
                        Console.BackgroundColor = conColor;
                        string colorName = conColor.ToString();
                        Console.Write("\t" + colorName);

                        Sounds.PlaySoundForColor(conColor);

                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ResetColor();
                        string colorName = simonColors[x].ToString();
                        Console.Write("\t" + colorName);
                    }
                    if (x == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    else Console.Write("     ");
                }
                Thread.Sleep(delayInMs);
                Console.Clear();
                Console.WriteLine();
                //show it empty so that repeated colors are seen.
                for (int x = 0; x < 4; x++)
                {
                    Console.ResetColor();
                    string colorName = simonColors[x].ToString();
                    Console.Write("\t" + colorName);

                    if (x == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    else Console.Write("     ");
                }

                Thread.Sleep(100);
                Console.Clear();
            }
        }

        public static Button[] GenerateListOfButtons(int len)
        {
            Random random = new Random();
            Button[] colorList = new Button[len];
            for (int i = 0; i < len; i++)
            {
                //gen random color
                int r = random.Next(0, 4);
                Button button = new Button();
                button.character = simonChars[r];
                button.color = simonColors[r];
                colorList[i] = button;
            }
            return colorList;
        }
    }
}
