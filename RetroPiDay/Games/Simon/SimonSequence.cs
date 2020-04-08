using System;
using System.Threading;

namespace RetroPiDay.Games.Simon
{
    public static class SimonSequence
    {
        private static Random random = new Random();

        public static void PlaySequence(Button[] buttonList, int delayInMs)
        {
            for (int i = 0; i < buttonList.Length; i++)
            {
                var button = buttonList[i];

                // display button and play sound
                //Display.Display(button);
                Console.Clear();
                Console.BackgroundColor = button.color;
                Console.WriteLine(button.character);

                Sounds.PlaySoundForColor(button.color);
                Thread.Sleep((int)(0.75 * delayInMs));

                // show 
                //Display.Display();
                Console.Clear();
                Thread.Sleep((int)(0.25 * delayInMs));
            }
        }

        public static Button[] GenerateSequence(int len)
        {
            Button[] buttonList = new Button[len];
            for (int i = 0; i < len; i++)
            {
                buttonList[i] = GetRandomButton();
            }
            return buttonList;
        }

        private static Button GetRandomButton()
        {
            int r = random.Next(0, 4);
            switch(r)
            {
                case 0:
                    return Buttons.Red;
                case 1:
                    return Buttons.Blue;
                case 2:
                    return Buttons.Green;
                case 3:
                    return Buttons.Yellow;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
