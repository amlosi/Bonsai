using System;
using System.Collections.Generic;
using System.Linq;

namespace RetroPiDay.Games.Simon
{
    public struct Button
    {
        public char character;
        public ConsoleColor color;
    }

    public enum ButtonName
    {
        Red,
        Green,
        Blue,
        Yellow
    }

    public static class Buttons
    {
        private static Dictionary<ButtonName, Button> validButtons = new Dictionary<ButtonName, Button>()
        {
            { ButtonName.Red, new Button() { character = 'r', color = ConsoleColor.Red } },
            { ButtonName.Green, new Button() { character = 'g', color = ConsoleColor.Green } },
            { ButtonName.Blue, new Button() { character = 'b', color = ConsoleColor.Blue } },
            { ButtonName.Yellow, new Button() { character = 'y', color = ConsoleColor.Yellow } }
        };

        private static List<char> validButtonCharacters = validButtons.Select(kvp => kvp.Value.character).ToList();

        public static Button Red => validButtons[ButtonName.Red];

        public static Button Green => validButtons[ButtonName.Green];

        public static Button Blue => validButtons[ButtonName.Blue];

        public static Button Yellow => validButtons[ButtonName.Yellow];

        public static bool isValidButtonInput(char input)
        {
            if (validButtonCharacters.Contains(Char.ToLowerInvariant(input)))
            {
                return true;
            }

            return false;
        }
    }
}
