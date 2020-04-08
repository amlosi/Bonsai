using System;
using System.Collections.Generic;

namespace Simon
{
    public static class Sounds
    {
        private static Dictionary<char, int> _colorKeySounds = new Dictionary<char, int>();
        private static Dictionary<ConsoleColor, int> _colorSounds = new Dictionary<ConsoleColor, int>();

        static Sounds()
        {
            int baseFreq = 900;

            _colorKeySounds.Add('g', baseFreq);
            _colorKeySounds.Add('r', (int)(baseFreq * .75));
            _colorKeySounds.Add('b', (int)(baseFreq * .50));
            _colorKeySounds.Add('y', (int)(baseFreq * .25));

            _colorSounds.Add(ConsoleColor.Green, baseFreq);
            _colorSounds.Add(ConsoleColor.Red, (int)(baseFreq * .75));
            _colorSounds.Add(ConsoleColor.Blue, (int)(baseFreq * .50));
            _colorSounds.Add(ConsoleColor.Yellow, (int)(baseFreq * .25));
        }

        public static void PlaySoundForColorKey(char color)
        {
            if (_colorKeySounds.TryGetValue(color, out int frequency))
            {
                Console.Beep(frequency, 500);
            }
            else
            {
                PlayInvalidCharacterSound();
            }
        }

        public static void PlaySoundForColor(ConsoleColor color)
        {
            if (_colorSounds.TryGetValue(color, out int frequency))
            {
                Console.Beep(frequency, 500);
            }
        }

        public static void PlayInvalidCharacterSound()
        {
            Console.Beep(100, 1500);
        }

        public static void PlayIntroSong()
        {
            PlaySoundForColor(ConsoleColor.Green);
            PlaySoundForColor(ConsoleColor.Green);
            PlaySoundForColor(ConsoleColor.Red);
            PlaySoundForColor(ConsoleColor.Red);
            PlaySoundForColor(ConsoleColor.Yellow);
            PlaySoundForColor(ConsoleColor.Yellow);
            PlaySoundForColor(ConsoleColor.Blue);
        }
    }
}
