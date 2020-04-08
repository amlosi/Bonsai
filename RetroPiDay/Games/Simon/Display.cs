using System;

namespace RetroPiDay.Games.Simon
{
    static class Display
    {
        public static void Show()
        {
            // line number
            // 1,2
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                 .#############.                                ");
            Console.WriteLine("                         .%%%%%&&&&&&%%%%%%@&&&&&&&%%%%.                        ");
            // 3
            Console.Write("                     %%%%&&%");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("%%%%%%@");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("/////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("&@@%%%                    ");
            // 4
            Console.Write("                 #%%&&%");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(/////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("%%%%%%@");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("//////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@@%%%                ");
            // 5
            Console.Write("              %%%&&");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(/////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("%%%%%%@");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("/////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("&@&%%             ");
            // 6
            Console.Write("            %&&&");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(////////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("%%%%%%@");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("////////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("&@&&           ");
            // 7
            Console.Write("          &&&&");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(//////////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("%%%%%%@");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("//////////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("&@&&         ");
            // 8
            Console.Write("        %&&&");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(////////////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("%%%%%%@");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("/////////////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@&&       ");
            // 9
            Console.Write("       &&&");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(//////////////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("%%%%%%@");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("///////////////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@&&     ");
            // 10
            Console.Write("      &&&");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(////////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("##%%%%%%%%%%%%%%%%##");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("//////////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("&@&    ");
            // 11
            Console.Write("     @&&%");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("##&&&&&&&##########&&&&&&&##");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("///////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("&@@   ");
            // 12
            Console.Write("    @@&");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("##&&&&&                  &&&&&##");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("/////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@@@.  ");
            // 13
            Console.Write("   .@&");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(///////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("##_________.__                    ##");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@@@  ");
            // 14
            Console.Write("   @@&");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(//////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("##/   _____/|__| _____   ____   ____##");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("///////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            // 15-18
            Console.WriteLine("&@@  ");
            Console.WriteLine("   @@@%%%%%%%%%%%%%%%%%\\_____  \\ |  |/     \\ /  _ \\ /    \\%%%%%%%%%%%%%%%%%@@@  ");
            Console.WriteLine("   @@@@@&&&&&&&&&&&&&&&/        \\|  |  Y Y  (  <_> )   |  \\&&&&&&&&&&&&&&@@@@@  ");
            Console.WriteLine("   @@@################/_______  /|__|__|_|  /\\____/|___|  /################@@@  ");
            // 19
            Console.Write("   @@@");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("(//////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("###      \\/          \\/            \\/##");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("//////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@@@  ");
            // 20
            Console.Write("    @@@");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("(///////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("##&&&&     Press [enter]     &&&&##");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@@.  ");
            // 21
            Console.Write("    .@@&");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("(////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("##&&&&&     to play     &&&&&##");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("/////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@@@   ");
            // 22
            Console.Write("     @@@&");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("(///////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("##&&&&&&&&###&&&&&&&&##");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("////////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@@@     ");
            // 23
            Console.Write("      @@@&");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("(/////////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("##&&&&&&&&&&&&&##");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("//////////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@@@     ");
            // 24            
            Console.Write("       *@@@");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("(/////////////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("#@@@@@&");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("//////////////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@@@      ");
            // 25            
            Console.Write("         @@@");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("(////////////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("#@@@@@&");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("////////////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@@@        ");
            // 26           
            Console.Write("           @@@");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("(//////////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("#@@@@@&");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("//////////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@@@.         ");
            // 27
            Console.Write("             @@@@");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("(///////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("#@@@@@&");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("////////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("&@@            ");
            // 28
            Console.Write("               *@@@@");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("(////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("#@@@@@&");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("/////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("&@@@              ");
            // 29            
            Console.Write("                  *@@@@");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("(/////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("#@@@@@&");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("/////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@@@@*                 ");
            // 30            
            Console.Write("                      *@@@@@@%");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("(//////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("#@@@@@&");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("//////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("%@@@@@@*                     ");
            // 31-35
            Console.WriteLine("                            *@@@@@@@@@@@@@@@@@@@@@@@*                           ");
            Console.WriteLine("         ___ __ ___ __    _____                 ___                    _ ");
            Console.WriteLine("        |_  )  \\_  )  \\  |_   _|__ __ _ _ __   | _ ) ___ _ _  ___ __ _(_)");
            Console.WriteLine("         / / () / / () |   | |/ -_) _` | '  \\  | _ \\/ _ \\ ' \\(_-</ _` | |");
            Console.WriteLine("        /___\\__/___\\__/    |_|\\___\\__,_|_|_|_| |___/\\___/_||_/__/\\__,_|_|");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }
        }
    }
}
