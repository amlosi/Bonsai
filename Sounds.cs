using System;
using System.Collections.Generic;

namespace Simon
{
    public static class Sounds
    {
        private static Dictionary<char, int> _colorSounds = new Dictionary<char, int>();

        static Sounds()
        {
            int baseFreq = 900;

            _colorSounds.Add('g', baseFreq);
            _colorSounds.Add('r', (int)(baseFreq * .75));
            _colorSounds.Add('b', (int)(baseFreq * .50));
            _colorSounds.Add('y', (int)(baseFreq * .25));
        }

        public static void PlaySoundForColor(char color)
        {
            if (_colorSounds.TryGetValue(color, out int frequency))
            {
                Console.Beep(frequency, 500);
            }
            else
            {
                PlayInvalidCharacterSound();
            }
        }

        public static void PlayInvalidCharacterSound()
        {
            Console.Beep(100, 1500);
        }

        public static void PlayIntroSong()
        {
        }
    }
}
