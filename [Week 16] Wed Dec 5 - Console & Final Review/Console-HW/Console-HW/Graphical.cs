using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_HW
{
    class Graphical // (Bonus -- Second Class)
    {
        public static string intro = "\n\tWelcome!\n\n\tThe is the Struct-Tut program re-written for the console. \n\n\tNow let's try to get some bonus points. :)";

        public static void AsciiArt()
        {
            Console.WriteLine("\n\t .d8888b.                                      888                 888    888 888       888 \r\n" +
                                "\td88P  Y88b                                     888                 888    888 888   o   888 \r\n" +
                                "\t888    888                                     888                 888    888 888  d8b  888 \r\n" +
                                "\t888         .d88b.  88888b.  .d8888b   .d88b.  888  .d88b.         8888888888 888 d888b 888 \r\n" +
                                "\t888        d88\"\"88b 888 \"88b 88K      d88\"\"88b 888 d8P  Y8b        888    888 888d88888b888 \r\n" +
                                "\t888    888 888  888 888  888 \"Y8888b. 888  888 888 88888888 888888 888    888 88888P Y88888 \r\n" +
                                "\tY88b  d88P Y88..88P 888  888      X88 Y88..88P 888 Y8b.            888    888 8888P   Y8888 \r\n" +
                                "\t \"Y8888P\"   \"Y88P\"  888  888  88888P'  \"Y88P\"  888  \"Y8888         888    888 888P     Y888 \r\n\n\n");
        }

        public static void DelayedPrint(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
        }

        public static void Closed()
        {
            string text = "\r\n" +
                          "\t    ______   _  __    ____   ______   ____   _   __   ______             \r\n" +
                          "\t   / ____/  | |/ /   /  _/  /_  __/  /  _/  / | / /  / ____/             \r\n" +
                          "\t  / __/     |   /    / /     / /     / /   /  |/ /  / / __               \r\n" +
                          "\t / /___    /   |   _/ /     / /    _/ /   / /|  /  / /_/ /  _    _    _  \r\n" +
                          "\t/_____/   /_/|_|  /___/    /_/    /___/  /_/ |_/   \\____/  (_)  (_)  (_) \r\n";

            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(5);
            }

            Thread.Sleep(2000);
        }

        public static void Menu()
        {
            Console.WriteLine("\n\n\t***************************\n" +
                                "\t*        MAIN MENU        *\n" +
                                "\t***************************\n" +
                                "\t* Enter 1 to Load A File  *\n" +
                                "\t* Enter 2 for LINQ Search *\n" +
                                "\t* Enter 3 to Save A File  *\n" +
                                "\t* Enter 4 to Exit         *\n" +
                                "\t***************************");

        }
    }
}
