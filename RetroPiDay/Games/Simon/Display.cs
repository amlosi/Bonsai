using System;

namespace RetroPiDay.Games.Simon
{
    static class Display
    {
        public static void Show()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("                                 .#############.                                ");
            Console.WriteLine("                         .%%%%%&&&&&&%%%%%%@&&&&&&&%%%%.                        ");
            Console.Write("                     %%%%&&%");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("%%%%%%@");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("/////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("&@@%%%                    ");
            Console.Write("                 #%%&&%");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(/////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("%%%%%%@");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("//////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@@%%%                ");
            Console.Write("              %%%&&");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(/////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("%%%%%%@");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("/////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("&@&%%             ");
            Console.Write("            %&&&");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(////////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("%%%%%%@");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("////////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("&@&&           ");
            Console.Write("          &&&&");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(//////////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("%%%%%%@");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("//////////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("&@&&         ");

            // Console.WriteLine("        %&&&(////////////////////////%%%%%%@/////////////////////////)@&&       ");
            Console.Write("        %&&&");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(////////////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("%%%%%%@");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("/////////////////////////)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("@&&       ");

            // Console.WriteLine("       &&&(//////////////////////////%%%%%%@///////////////////////////)@&&     ");
            Console.Write("       &&&");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("(//////////////////////////");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("%%%%%%@");
            Console.Write("///////////////////////////)");
            Console.WriteLine("@&&     ");

            // Console.WriteLine("      &&&(////////////////////##%%%%%%%%%%%%%%%%##//////////////////////)&@&    ");
            Console.Write("      &&&");
            Console.Write("(////////////////////");
            Console.Write("##%%%%%%%%%%%%%%%%##");
            Console.Write("//////////////////////)");
            Console.WriteLine("&@&    ");

            //.WriteLine("     @&&%(////////////////##&&&&&&&##########&&&&&&&##///////////////////)&@@   ");
            Console.Write("     @&&%");
            Console.Write("(////////////////");
            Console.Write("##&&&&&&&##########&&&&&&&##");
            Console.Write("///////////////////)");
            Console.WriteLine("&@@   ");

            // Console.WriteLine("    @@&(////////////////##&&&&&                  &&&&&##/////////////////)@@@.  ");
            Console.Write("    @@&");
            Console.Write("(////////////////");
            Console.Write("##&&&&&                  &&&&&##");
            Console.Write("/////////////////)");
            Console.WriteLine("@@@.  ");

            // Console.WriteLine("   .@&(///////////////##_________.__                    ##////////////////)@@@  ");
            Console.Write("   .@&");
            Console.Write("(///////////////");
            Console.Write("##_________.__                    ##");
            Console.Write("////////////////)");
            Console.WriteLine("@@@  ");

            // Console.WriteLine("   @@&(//////////////##/   _____/|__| _____   ____   ____##///////////////)&@@  ");
            Console.Write("   @@&");
            Console.Write("(//////////////");
            Console.Write("##/   _____/|__| _____   ____   ____##");
            Console.Write("///////////////)");
            Console.WriteLine("&@@  ");
            Console.WriteLine("   @@@%%%%%%%%%%%%%%%%%\\_____  \\ |  |/     \\ /  _ \\ /    \\%%%%%%%%%%%%%%%%%@@@  ");
            Console.WriteLine("   @@@@@&&&&&&&&&&&&&&&/        \\|  |  Y Y  (  <_> )   |  \\&&&&&&&&&&&&&&@@@@@  ");
            Console.WriteLine("   @@@################/_______  /|__|__|_|  /\\____/|___|  /################@@@  ");
            // Console.WriteLine("   @@@(//////////////###      \\/          \\/            \\/##//////////////)@@@  ");
            Console.Write("   @@@");
            Console.Write("(//////////////");
            Console.Write("###      \\/          \\/            \\/##");
            Console.Write("//////////////)");
            Console.WriteLine("@@@  ");
            //Console.WriteLine("    @@@(///////////////##&&&&     Press [enter]     &&&&##////////////////)@@.  ");
            Console.Write("    @@@");
            Console.Write("(///////////////");
            Console.Write("##&&&&     Press [enter]     &&&&##");
            Console.Write("////////////////)");
            Console.WriteLine("@@.  ");
            // Console.WriteLine("    .@@&(////////////////##&&&&&     to play     &&&&&##/////////////////)@@@   ");
            Console.Write("    .@@&");
            Console.Write("(////////////////");
            Console.Write("##&&&&&     to play     &&&&&##");
            Console.Write("/////////////////)");
            Console.WriteLine("@@@   ");
            // Console.WriteLine("     @@@&(///////////////////##&&&&&&&&###&&&&&&&&##///////////////////)@@@     ");
            Console.Write("     @@@&");
            Console.Write("(///////////////////");
            Console.Write("##&&&&&&&&###&&&&&&&&##");
            Console.Write("////////////////////)");
            Console.WriteLine("@@@     ");
            // Console.WriteLine("      @@@&(/////////////////////##&&&&&&&&&&&&&##//////////////////////)@@@     ");
            Console.Write("      @@@&");
            Console.Write("(/////////////////////");
            Console.Write("##&&&&&&&&&&&&&##");
            Console.Write("//////////////////////)");
            Console.WriteLine("@@@     ");
            // Console.WriteLine("       *@@@(/////////////////////////#@@@@@&//////////////////////////)@@@      ");
            Console.Write("       *@@@");
            Console.Write("(/////////////////////////");
            Console.Write("#@@@@@&");
            Console.Write("//////////////////////////)");
            Console.WriteLine("@@@      ");
            // Console.WriteLine("         @@@(////////////////////////#@@@@@&////////////////////////)@@@        ");
            Console.Write("         @@@");
            Console.Write("(////////////////////////");
            Console.Write("#@@@@@&");
            Console.Write("////////////////////////)");
            Console.WriteLine("@@@        ");
            // Console.WriteLine("           @@@(//////////////////////#@@@@@&//////////////////////)@@@.         ");
            Console.Write("           @@@");
            Console.Write("(//////////////////////");
            Console.Write("#@@@@@&");
            Console.Write("//////////////////////)");
            Console.WriteLine("@@@.         ");
            // Console.WriteLine("             @@@@(///////////////////#@@@@@&////////////////////)&@@            ");
            Console.Write("             @@@@");
            Console.Write("(///////////////////");
            Console.Write("#@@@@@&");
            Console.Write("////////////////////)");
            Console.WriteLine("&@@            ");
            // Console.WriteLine("               *@@@@(////////////////#@@@@@&/////////////////)&@@@              ");
            Console.Write("               *@@@@");
            Console.Write("(////////////////");
            Console.Write("#@@@@@&");
            Console.Write("/////////////////)");
            Console.WriteLine("&@@@              ");
            // Console.WriteLine("                  *@@@@(/////////////#@@@@@&/////////////)@@@@*                 ");
            Console.Write("                  *@@@@");
            Console.Write("(/////////////");
            Console.Write("#@@@@@&");
            Console.Write("/////////////)");
            Console.WriteLine("@@@@*                 ");
            // Console.WriteLine("                      *@@@@@@%(//////#@@@@@&//////)%@@@@@@*                     ");
            Console.Write("                      *@@@@@@%");
            Console.Write("(//////");
            Console.Write("#@@@@@&");
            Console.Write("//////)");
            Console.WriteLine("%@@@@@@*                     ");


            Console.WriteLine("                            *@@@@@@@@@@@@@@@@@@@@@@@*                           ");
            Console.WriteLine("         ___ __ ___ __    _____                 ___                    _ ");
            Console.WriteLine("        |_  )  \\_  )  \\  |_   _|__ __ _ _ __   | _ ) ___ _ _  ___ __ _(_)");
            Console.WriteLine("         / / () / / () |   | |/ -_) _` | '  \\  | _ \\/ _ \\ ' \\(_-</ _` | |");
            Console.WriteLine("        /___\\__/___\\__/    |_|\\___\\__,_|_|_|_| |___/\\___/_||_/__/\\__,_|_|");
        }
    }
}
