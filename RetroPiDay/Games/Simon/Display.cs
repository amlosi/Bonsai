using System;

namespace RetroPiDay.Games.Simon
{
    static class Display
    {
        public static void DisplaySplashScreen()
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

        public static void DisplayButton(char c)
        {
            Console.Clear();

            if (c == 'g')
            {
                DisplayGreen();
            }
            else if (c == 'r')
            {
                DisplayRed();
            }
            else if (c == 'y')
            {
                DisplayYellow();
            }
            else if (c == 'b')
            {
                DisplayBlue();
            }
            else
            {
                DisplayBlank();
            }
        }

        public static void DisplayGreen()
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
            Console.Write("/////////)");
            Console.WriteLine("&@@%%%                    ");
            // 4
            Console.Write("                 #%%&&%");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(/////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("%%%%%%@");
            Console.Write("//////////////)");
            Console.WriteLine("@@%%%                ");
            // 5
            Console.Write("              %%%&&");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(/////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("%%%%%%@");
            Console.Write("/////////////////)");
            Console.WriteLine("&@&%%             ");
            // 6
            Console.Write("            %&&&");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(////////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("%%%%%%@");
            Console.Write("////////////////////)");
            Console.WriteLine("&@&&           ");
            // 7
            Console.Write("          &&&&");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(//////////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("%%%%%%@");
            Console.Write("//////////////////////)");
            Console.WriteLine("&@&&         ");
            // 8
            Console.Write("        %&&&");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(////////////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("%%%%%%@");
            Console.Write("/////////////////////////)");
            Console.WriteLine("@&&       ");
            // 9
            Console.Write("       &&&");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(//////////////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("%%%%%%@");
            Console.Write("///////////////////////////)");
            Console.WriteLine("@&&     ");
            // 10
            Console.Write("      &&&");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(////////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("##%%%%%%%%%%%%%%%%##");
            Console.Write("//////////////////////)");
            Console.WriteLine("&@&    ");
            // 11
            Console.Write("     @&&%");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("##&&&&&&&##########&&&&&&&##");
            Console.Write("///////////////////)");
            Console.WriteLine("&@@   ");
            // 12
            Console.Write("    @@&");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("##&&&&&                  &&&&&##");
            Console.Write("/////////////////)");
            Console.WriteLine("@@@.  ");
            // 13
            Console.Write("   .@&");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(///////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("##_________.__                    ##");
            Console.Write("////////////////)");
            Console.WriteLine("@@@  ");
            // 14
            Console.Write("   @@&");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(//////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("##/   _____/|__| _____   ____   ____##");
            Console.Write("///////////////)");
            // 15-18
            Console.WriteLine("&@@  ");
            Console.WriteLine("   @@@%%%%%%%%%%%%%%%%%\\_____  \\ |  |/     \\ /  _ \\ /    \\%%%%%%%%%%%%%%%%%@@@  ");
            Console.WriteLine("   @@@@@&&&&&&&&&&&&&&&/        \\|  |  Y Y  (  <_> )   |  \\&&&&&&&&&&&&&&@@@@@  ");
            Console.WriteLine("   @@@################/_______  /|__|__|_|  /\\____/|___|  /################@@@  ");
            // 19
            Console.Write("   @@@");
            Console.Write("(//////////////");
            Console.Write("###      \\/          \\/            \\/##");
            Console.Write("//////////////)");
            Console.WriteLine("@@@  ");
            // 20
            Console.Write("    @@@");
            Console.Write("(///////////////");
            Console.Write("##&&&&                       &&&&##");
            Console.Write("////////////////)");
            Console.WriteLine("@@.  ");
            // 21
            Console.Write("    .@@&");
            Console.Write("(////////////////");
            Console.Write("##&&&&&                 &&&&&##");
            Console.Write("/////////////////)");
            Console.WriteLine("@@@   ");
            // 22
            Console.Write("     @@@&");
            Console.Write("(///////////////////");
            Console.Write("##&&&&&&&&###&&&&&&&&##");
            Console.Write("////////////////////)");
            Console.WriteLine("@@@     ");
            // 23
            Console.Write("      @@@&");
            Console.Write("(/////////////////////");
            Console.Write("##&&&&&&&&&&&&&##");
            Console.Write("//////////////////////)");
            Console.WriteLine("@@@     ");
            // 24            
            Console.Write("       *@@@");
            Console.Write("(/////////////////////////");
            Console.Write("#@@@@@&");
            Console.Write("//////////////////////////)");
            Console.WriteLine("@@@      ");
            // 25            
            Console.Write("         @@@");
            Console.Write("(////////////////////////");
            Console.Write("#@@@@@&");
            Console.Write("////////////////////////)");
            Console.WriteLine("@@@        ");
            // 26           
            Console.Write("           @@@");
            Console.Write("(//////////////////////");
            Console.Write("#@@@@@&");
            Console.Write("//////////////////////)");
            Console.WriteLine("@@@.         ");
            // 27
            Console.Write("             @@@@");
            Console.Write("(///////////////////");
            Console.Write("#@@@@@&");
            Console.Write("////////////////////)");
            Console.WriteLine("&@@            ");
            // 28
            Console.Write("               *@@@@");
            Console.Write("(////////////////");
            Console.Write("#@@@@@&");
            Console.Write("/////////////////)");
            Console.WriteLine("&@@@              ");
            // 29            
            Console.Write("                  *@@@@");
            Console.Write("(/////////////");
            Console.Write("#@@@@@&");
            Console.Write("/////////////)");
            Console.WriteLine("@@@@*                 ");
            // 30            
            Console.Write("                      *@@@@@@%");
            Console.Write("(//////");
            Console.Write("#@@@@@&");
            Console.Write("//////)");
            Console.WriteLine("%@@@@@@*                     ");
            // 31
            Console.WriteLine("                            *@@@@@@@@@@@@@@@@@@@@@@@*                           ");
        }

        public static void DisplayRed()
        {
            // line number
            // 1,2
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                 .#############.                                ");
            Console.WriteLine("                         .%%%%%&&&&&&%%%%%%@&&&&&&&%%%%.                        ");
            // 3
            Console.Write("                     %%%%&&%");
            Console.Write("(////////");
            Console.Write("%%%%%%@");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("/////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("&@@%%%                    ");
            // 4
            Console.Write("                 #%%&&%");
            Console.Write("(/////////////");
            Console.Write("%%%%%%@");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("//////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@@%%%                ");
            // 5
            Console.Write("              %%%&&");
            Console.Write("(/////////////////");
            Console.Write("%%%%%%@");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("/////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("&@&%%             ");
            // 6
            Console.Write("            %&&&");
            Console.Write("(////////////////////");
            Console.Write("%%%%%%@");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("////////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("&@&&           ");
            // 7
            Console.Write("          &&&&");
            Console.Write("(//////////////////////");
            Console.Write("%%%%%%@");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("//////////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("&@&&         ");
            // 8
            Console.Write("        %&&&");
            Console.Write("(////////////////////////");
            Console.Write("%%%%%%@");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("/////////////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@&&       ");
            // 9
            Console.Write("       &&&");
            Console.Write("(//////////////////////////");
            Console.Write("%%%%%%@");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("///////////////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@&&     ");
            // 10
            Console.Write("      &&&");
            Console.Write("(////////////////////");
            Console.Write("##%%%%%%%%%%%%%%%%##");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("//////////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("&@&    ");
            // 11
            Console.Write("     @&&%");
            Console.Write("(////////////////");
            Console.Write("##&&&&&&&##########&&&&&&&##");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("///////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("&@@   ");
            // 12
            Console.Write("    @@&");
            Console.Write("(////////////////");
            Console.Write("##&&&&&                  &&&&&##");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("/////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@@@.  ");
            // 13
            Console.Write("   .@&");
            Console.Write("(///////////////");
            Console.Write("##_________.__                    ##");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@@@  ");
            // 14
            Console.Write("   @@&");
            Console.Write("(//////////////");
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
            Console.Write("(//////////////");
            Console.Write("###      \\/          \\/            \\/##");
            Console.Write("//////////////)");
            Console.WriteLine("@@@  ");
            // 20
            Console.Write("    @@@");
            Console.Write("(///////////////");
            Console.Write("##&&&&                       &&&&##");
            Console.Write("////////////////)");
            Console.WriteLine("@@.  ");
            // 21
            Console.Write("    .@@&");
            Console.Write("(////////////////");
            Console.Write("##&&&&&                 &&&&&##");
            Console.Write("/////////////////)");
            Console.WriteLine("@@@   ");
            // 22
            Console.Write("     @@@&");
            Console.Write("(///////////////////");
            Console.Write("##&&&&&&&&###&&&&&&&&##");
            Console.Write("////////////////////)");
            Console.WriteLine("@@@     ");
            // 23
            Console.Write("      @@@&");
            Console.Write("(/////////////////////");
            Console.Write("##&&&&&&&&&&&&&##");
            Console.Write("//////////////////////)");
            Console.WriteLine("@@@     ");
            // 24            
            Console.Write("       *@@@");
            Console.Write("(/////////////////////////");
            Console.Write("#@@@@@&");
            Console.Write("//////////////////////////)");
            Console.WriteLine("@@@      ");
            // 25            
            Console.Write("         @@@");
            Console.Write("(////////////////////////");
            Console.Write("#@@@@@&");
            Console.Write("////////////////////////)");
            Console.WriteLine("@@@        ");
            // 26           
            Console.Write("           @@@");
            Console.Write("(//////////////////////");
            Console.Write("#@@@@@&");
            Console.Write("//////////////////////)");
            Console.WriteLine("@@@.         ");
            // 27
            Console.Write("             @@@@");
            Console.Write("(///////////////////");
            Console.Write("#@@@@@&");
            Console.Write("////////////////////)");
            Console.WriteLine("&@@            ");
            // 28
            Console.Write("               *@@@@");
            Console.Write("(////////////////");
            Console.Write("#@@@@@&");
            Console.Write("/////////////////)");
            Console.WriteLine("&@@@              ");
            // 29            
            Console.Write("                  *@@@@");
            Console.Write("(/////////////");
            Console.Write("#@@@@@&");
            Console.Write("/////////////)");
            Console.WriteLine("@@@@*                 ");
            // 30            
            Console.Write("                      *@@@@@@%");
            Console.Write("(//////");
            Console.Write("#@@@@@&");
            Console.Write("//////)");
            Console.WriteLine("%@@@@@@*                     ");
            // 31
            Console.WriteLine("                            *@@@@@@@@@@@@@@@@@@@@@@@*                           ");
        }

        public static void DisplayYellow()
        {
            // line number
            // 1,2 
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                 .#############.                                ");
            Console.WriteLine("                         .%%%%%&&&&&&%%%%%%@&&&&&&&%%%%.                        ");
            // 3
            Console.Write("                     %%%%&&%");
            Console.Write("(////////");
            Console.Write("%%%%%%@");
            Console.Write("/////////)");
            Console.WriteLine("&@@%%%                    ");
            // 4
            Console.Write("                 #%%&&%");
            Console.Write("(/////////////");
            Console.Write("%%%%%%@");
            Console.Write("//////////////)");
            Console.WriteLine("@@%%%                ");
            // 5
            Console.Write("              %%%&&");
            Console.Write("(/////////////////");
            Console.Write("%%%%%%@");
            Console.Write("/////////////////)");
            Console.WriteLine("&@&%%             ");
            // 6
            Console.Write("            %&&&");
            Console.Write("(////////////////////");
            Console.Write("%%%%%%@");
            Console.Write("////////////////////)");
            Console.WriteLine("&@&&           ");
            // 7
            Console.Write("          &&&&");
            Console.Write("(//////////////////////");
            Console.Write("%%%%%%@");
            Console.Write("//////////////////////)");
            Console.WriteLine("&@&&         ");
            // 8
            Console.Write("        %&&&");
            Console.Write("(////////////////////////");
            Console.Write("%%%%%%@");
            Console.Write("/////////////////////////)");
            Console.WriteLine("@&&       ");
            // 9
            Console.Write("       &&&");
            Console.Write("(//////////////////////////");
            Console.Write("%%%%%%@");
            Console.Write("///////////////////////////)");
            Console.WriteLine("@&&     ");
            // 10
            Console.Write("      &&&");
            Console.Write("(////////////////////");
            Console.Write("##%%%%%%%%%%%%%%%%##");
            Console.Write("//////////////////////)");
            Console.WriteLine("&@&    ");
            // 11
            Console.Write("     @&&%");
            Console.Write("(////////////////");
            Console.Write("##&&&&&&&##########&&&&&&&##");
            Console.Write("///////////////////)");
            Console.WriteLine("&@@   ");
            // 12
            Console.Write("    @@&");
            Console.Write("(////////////////");
            Console.Write("##&&&&&                  &&&&&##");
            Console.Write("/////////////////)");
            Console.WriteLine("@@@.  ");
            // 13
            Console.Write("   .@&");
            Console.Write("(///////////////");
            Console.Write("##_________.__                    ##");
            Console.Write("////////////////)");
            Console.WriteLine("@@@  ");
            // 14
            Console.Write("   @@&");
            Console.Write("(//////////////");
            Console.Write("##/   _____/|__| _____   ____   ____##");
            Console.Write("///////////////)");
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
            Console.Write("//////////////)");
            Console.WriteLine("@@@  ");
            // 20
            Console.Write("    @@@");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("(///////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("##&&&&                       &&&&##");
            Console.Write("////////////////)");
            Console.WriteLine("@@.  ");
            // 21
            Console.Write("    .@@&");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("(////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("##&&&&&                 &&&&&##");
            Console.Write("/////////////////)");
            Console.WriteLine("@@@   ");
            // 22
            Console.Write("     @@@&");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("(///////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("##&&&&&&&&###&&&&&&&&##");
            Console.Write("////////////////////)");
            Console.WriteLine("@@@     ");
            // 23
            Console.Write("      @@@&");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("(/////////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("##&&&&&&&&&&&&&##");
            Console.Write("//////////////////////)");
            Console.WriteLine("@@@     ");
            // 24            
            Console.Write("       *@@@");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("(/////////////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("#@@@@@&");
            Console.Write("//////////////////////////)");
            Console.WriteLine("@@@      ");
            // 25            
            Console.Write("         @@@");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("(////////////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("#@@@@@&");
            Console.Write("////////////////////////)");
            Console.WriteLine("@@@        ");
            // 26           
            Console.Write("           @@@");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("(//////////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("#@@@@@&");
            Console.Write("//////////////////////)");
            Console.WriteLine("@@@.         ");
            // 27
            Console.Write("             @@@@");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("(///////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("#@@@@@&");
            Console.Write("////////////////////)");
            Console.WriteLine("&@@            ");
            // 28
            Console.Write("               *@@@@");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("(////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("#@@@@@&");
            Console.Write("/////////////////)");
            Console.WriteLine("&@@@              ");
            // 29            
            Console.Write("                  *@@@@");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("(/////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("#@@@@@&");
            Console.Write("/////////////)");
            Console.WriteLine("@@@@*                 ");
            // 30            
            Console.Write("                      *@@@@@@%");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("(//////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("#@@@@@&");
            Console.Write("//////)");
            Console.WriteLine("%@@@@@@*                     ");
            // 31
            Console.WriteLine("                            *@@@@@@@@@@@@@@@@@@@@@@@*                           ");
        }

        public static void DisplayBlue()
        {
            // line number
            // 1,2
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                 .#############.                                ");
            Console.WriteLine("                         .%%%%%&&&&&&%%%%%%@&&&&&&&%%%%.                        ");
            // 3 
            Console.Write("                     %%%%&&%");
            Console.Write("(////////");
            Console.Write("%%%%%%@");
            Console.Write("/////////)");
            Console.WriteLine("&@@%%%                    ");
            // 4
            Console.Write("                 #%%&&%");
            Console.Write("(/////////////");
            Console.Write("%%%%%%@");
            Console.Write("//////////////)");
            Console.WriteLine("@@%%%                ");
            // 5
            Console.Write("              %%%&&");
            Console.Write("(/////////////////");
            Console.Write("%%%%%%@");
            Console.Write("/////////////////)");
            Console.WriteLine("&@&%%             ");
            // 6
            Console.Write("            %&&&");
            Console.Write("(////////////////////");
            Console.Write("%%%%%%@");
            Console.Write("////////////////////)");
            Console.WriteLine("&@&&           ");
            // 7
            Console.Write("          &&&&");
            Console.Write("(//////////////////////");
            Console.Write("%%%%%%@");
            Console.Write("//////////////////////)");
            Console.WriteLine("&@&&         ");
            // 8
            Console.Write("        %&&&");
            Console.Write("(////////////////////////");
            Console.Write("%%%%%%@");
            Console.Write("/////////////////////////)");
            Console.WriteLine("@&&       ");
            // 9
            Console.Write("       &&&");
            Console.Write("(//////////////////////////");
            Console.Write("%%%%%%@");
            Console.Write("///////////////////////////)");
            Console.WriteLine("@&&     ");
            // 10
            Console.Write("      &&&");
            Console.Write("(////////////////////");
            Console.Write("##%%%%%%%%%%%%%%%%##");
            Console.Write("//////////////////////)");
            Console.WriteLine("&@&    ");
            // 11
            Console.Write("     @&&%");
            Console.Write("(////////////////");
            Console.Write("##&&&&&&&##########&&&&&&&##");
            Console.Write("///////////////////)");
            Console.WriteLine("&@@   ");
            // 12
            Console.Write("    @@&");
            Console.Write("(////////////////");
            Console.Write("##&&&&&                  &&&&&##");
            Console.Write("/////////////////)");
            Console.WriteLine("@@@.  ");
            // 13
            Console.Write("   .@&");
            Console.Write("(///////////////");
            Console.Write("##_________.__                    ##");
            Console.Write("////////////////)");
            Console.WriteLine("@@@  ");
            // 14
            Console.Write("   @@&");
            Console.Write("(//////////////");
            Console.Write("##/   _____/|__| _____   ____   ____##");
            Console.Write("///////////////)");
            // 15-18
            Console.WriteLine("&@@  ");
            Console.WriteLine("   @@@%%%%%%%%%%%%%%%%%\\_____  \\ |  |/     \\ /  _ \\ /    \\%%%%%%%%%%%%%%%%%@@@  ");
            Console.WriteLine("   @@@@@&&&&&&&&&&&&&&&/        \\|  |  Y Y  (  <_> )   |  \\&&&&&&&&&&&&&&@@@@@  ");
            Console.WriteLine("   @@@################/_______  /|__|__|_|  /\\____/|___|  /################@@@  ");
            // 19
            Console.Write("   @@@");
            Console.Write("(//////////////");
            Console.Write("###      \\/          \\/            \\/##");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("//////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@@@  ");
            // 20
            Console.Write("    @@@");
            Console.Write("(///////////////");
            Console.Write("##&&&&                       &&&&##");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@@.  ");
            // 21
            Console.Write("    .@@&");
            Console.Write("(////////////////");
            Console.Write("##&&&&&                 &&&&&##");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("/////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@@@   ");
            // 22
            Console.Write("     @@@&");
            Console.Write("(///////////////////");
            Console.Write("##&&&&&&&&###&&&&&&&&##");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("////////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@@@     ");
            // 23
            Console.Write("      @@@&");
            Console.Write("(/////////////////////");
            Console.Write("##&&&&&&&&&&&&&##");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("//////////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@@@     ");
            // 24            
            Console.Write("       *@@@");
            Console.Write("(/////////////////////////");
            Console.Write("#@@@@@&");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("//////////////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@@@      ");
            // 25            
            Console.Write("         @@@");
            Console.Write("(////////////////////////");
            Console.Write("#@@@@@&");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("////////////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@@@        ");
            // 26           
            Console.Write("           @@@");
            Console.Write("(//////////////////////");
            Console.Write("#@@@@@&");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("//////////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@@@.         ");
            // 27
            Console.Write("             @@@@");
            Console.Write("(///////////////////");
            Console.Write("#@@@@@&");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("////////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("&@@            ");
            // 28
            Console.Write("               *@@@@");
            Console.Write("(////////////////");
            Console.Write("#@@@@@&");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("/////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("&@@@              ");
            // 29            
            Console.Write("                  *@@@@");
            Console.Write("(/////////////");
            Console.Write("#@@@@@&");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("/////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@@@@*                 ");
            // 30            
            Console.Write("                      *@@@@@@%");
            Console.Write("(//////");
            Console.Write("#@@@@@&");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("//////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("%@@@@@@*                     ");
            // 31
            Console.WriteLine("                            *@@@@@@@@@@@@@@@@@@@@@@@*                           ");
        }

        public static void DisplayBlank()
        {
            Console.Clear();

            // line number
            // 1,2
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("                                                                                ");
            Console.WriteLine("                                 .#############.                                ");
            Console.WriteLine("                         .%%%%%&&&&&&%%%%%%@&&&&&&&%%%%.                        ");
            // 3 
            Console.Write("                     %%%%&&%");
            Console.Write("(////////");
            Console.Write("%%%%%%@");
            Console.Write("/////////)");
            Console.WriteLine("&@@%%%                    ");
            // 4
            Console.Write("                 #%%&&%");
            Console.Write("(/////////////");
            Console.Write("%%%%%%@");
            Console.Write("//////////////)");
            Console.WriteLine("@@%%%                ");
            // 5
            Console.Write("              %%%&&");
            Console.Write("(/////////////////");
            Console.Write("%%%%%%@");
            Console.Write("/////////////////)");
            Console.WriteLine("&@&%%             ");
            // 6
            Console.Write("            %&&&");
            Console.Write("(////////////////////");
            Console.Write("%%%%%%@");
            Console.Write("////////////////////)");
            Console.WriteLine("&@&&           ");
            // 7
            Console.Write("          &&&&");
            Console.Write("(//////////////////////");
            Console.Write("%%%%%%@");
            Console.Write("//////////////////////)");
            Console.WriteLine("&@&&         ");
            // 8
            Console.Write("        %&&&");
            Console.Write("(////////////////////////");
            Console.Write("%%%%%%@");
            Console.Write("/////////////////////////)");
            Console.WriteLine("@&&       ");
            // 9
            Console.Write("       &&&");
            Console.Write("(//////////////////////////");
            Console.Write("%%%%%%@");
            Console.Write("///////////////////////////)");
            Console.WriteLine("@&&     ");
            // 10
            Console.Write("      &&&");
            Console.Write("(////////////////////");
            Console.Write("##%%%%%%%%%%%%%%%%##");
            Console.Write("//////////////////////)");
            Console.WriteLine("&@&    ");
            // 11
            Console.Write("     @&&%");
            Console.Write("(////////////////");
            Console.Write("##&&&&&&&##########&&&&&&&##");
            Console.Write("///////////////////)");
            Console.WriteLine("&@@   ");
            // 12
            Console.Write("    @@&");
            Console.Write("(////////////////");
            Console.Write("##&&&&&                  &&&&&##");
            Console.Write("/////////////////)");
            Console.WriteLine("@@@.  ");
            // 13
            Console.Write("   .@&");
            Console.Write("(///////////////");
            Console.Write("##_________.__                    ##");
            Console.Write("////////////////)");
            Console.WriteLine("@@@  ");
            // 14
            Console.Write("   @@&");
            Console.Write("(//////////////");
            Console.Write("##/   _____/|__| _____   ____   ____##");
            Console.Write("///////////////)");
            // 15-18
            Console.WriteLine("&@@  ");
            Console.WriteLine("   @@@%%%%%%%%%%%%%%%%%\\_____  \\ |  |/     \\ /  _ \\ /    \\%%%%%%%%%%%%%%%%%@@@  ");
            Console.WriteLine("   @@@@@&&&&&&&&&&&&&&&/        \\|  |  Y Y  (  <_> )   |  \\&&&&&&&&&&&&&&@@@@@  ");
            Console.WriteLine("   @@@################/_______  /|__|__|_|  /\\____/|___|  /################@@@  ");
            // 19
            Console.Write("   @@@");
            Console.Write("(//////////////");
            Console.Write("###      \\/          \\/            \\/##");
            Console.Write("//////////////)");
            Console.WriteLine("@@@  ");
            // 20
            Console.Write("    @@@");
            Console.Write("(///////////////");
            Console.Write("##&&&&                       &&&&##");
            Console.Write("////////////////)");
            Console.WriteLine("@@.  ");
            // 21
            Console.Write("    .@@&");
            Console.Write("(////////////////");
            Console.Write("##&&&&&                 &&&&&##");
            Console.Write("/////////////////)");
            Console.WriteLine("@@@   ");
            // 22
            Console.Write("     @@@&");
            Console.Write("(///////////////////");
            Console.Write("##&&&&&&&&###&&&&&&&&##");
            Console.Write("////////////////////)");
            Console.WriteLine("@@@     ");
            // 23
            Console.Write("      @@@&");
            Console.Write("(/////////////////////");
            Console.Write("##&&&&&&&&&&&&&##");
            Console.Write("//////////////////////)");
            Console.WriteLine("@@@     ");
            // 24            
            Console.Write("       *@@@");
            Console.Write("(/////////////////////////");
            Console.Write("#@@@@@&");
            Console.Write("//////////////////////////)");
            Console.WriteLine("@@@      ");
            // 25            
            Console.Write("         @@@");
            Console.Write("(////////////////////////");
            Console.Write("#@@@@@&");
            Console.Write("////////////////////////)");
            Console.WriteLine("@@@        ");
            // 26           
            Console.Write("           @@@");
            Console.Write("(//////////////////////");
            Console.Write("#@@@@@&");
            Console.Write("//////////////////////)");
            Console.WriteLine("@@@.         ");
            // 27
            Console.Write("             @@@@");
            Console.Write("(///////////////////");
            Console.Write("#@@@@@&");
            Console.Write("////////////////////)");
            Console.WriteLine("&@@            ");
            // 28
            Console.Write("               *@@@@");
            Console.Write("(////////////////");
            Console.Write("#@@@@@&");
            Console.Write("/////////////////)");
            Console.WriteLine("&@@@              ");
            // 29            
            Console.Write("                  *@@@@");
            Console.Write("(/////////////");
            Console.Write("#@@@@@&");
            Console.Write("/////////////)");
            Console.WriteLine("@@@@*                 ");
            // 30            
            Console.Write("                      *@@@@@@%");
            Console.Write("(//////");
            Console.Write("#@@@@@&");
            Console.Write("//////)");
            Console.WriteLine("%@@@@@@*                     ");
            // 31
            Console.WriteLine("                            *@@@@@@@@@@@@@@@@@@@@@@@*                           ");
        }
    }
}
