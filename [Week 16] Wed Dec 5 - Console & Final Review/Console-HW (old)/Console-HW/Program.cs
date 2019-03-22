using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Console_HW
{
    class Program
    {
        public static int choice = 0;

        static void Main(string[] args)
        {
            Graphical.AsciiArt(); // Display cool graphic

            // DelayPrint() gives you a cool text effect
            Graphical.DelayPrint("\tWelcome! This is the Console-HW program. I will try to get every bonus point =)\n");

            Menu(); // Display menu
            Graphical.DelayPrint("\tPlease make a selection: ");
            choice = Processing.IsNumber(Console.ReadLine());

           while (choice !=6)
            {
                if (choice >=1 && choice <= 5)
                {
                    switch (choice)
                    {
                        case 1:
                            InputFile();
                            break;
                        case 2:
                            OutputFile();
                            break;
                        case 3:
                            ArrayExample();
                            break;
                        case 4:
                            List();
                            break;
                        case 5:
                            Struct();
                            break;
                        case 6:
                            Environment.Exit(0); // Exit
                            break;
                        default: // Shouldn't get to this point, but just in case
                            Console.WriteLine("You broke the program! Back to the drawing board.\nPress any key to continue:");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                    }

                    Menu(); // Display menu
                    Graphical.DelayPrint("\tPlease make a selection: ");
                    choice = Processing.IsNumber(Console.ReadLine());
                }
                else
                {
                    Graphical.DelayPrint("\n\tInvalid choice. Please try again: ");
                    choice = Processing.IsNumber(Console.ReadLine());
                }
            }
        }

        public static void Menu()
        {
           Console.WriteLine("\n\n\t***************************\n" +
                               "\t*        MAIN MENU        *\n" +
                               "\t***************************\n" +
                               "\t* Enter 1 for File Input  *\n" +
                               "\t* Enter 2 for File Output *\n" +
                               "\t* Enter 3 for Array       *\n" +
                               "\t* Enter 4 for List        *\n" +
                               "\t* Enter 5 for Struct      *\n" +
                               "\t* Enter 6 to Exit         *\n" +
                               "\t***************************");

        }

        public static void InputFile()
        {
            Graphical.DelayPrint("\n\tBONUS: File Input (1 point)\n\tWe will start by loading our class info. Press any key to continue.\n\n");
            Console.ReadKey(); // Waiting for user to press any key

            // Load Class info (Bonus #1)
            Graphical.DelayPrint(Processing.ReadFile());

            Graphical.DelayPrint("\n\tThe class info was from the \"ClassInfo.txt\" file." +
                                 "\n\n\tPress any key to continue: ");
            Console.ReadKey();
        }

        public static void OutputFile()
        {
            // TODO
        }

        public static void ArrayExample()
        {
            Graphical.DelayPrint("\n\tBONUS: Array (2 points)\n\tGive me two numbers greater than zero and I will add them for you.\n" +
                                 "\n\tWhat is the first number?  ");

            int[] arrayExample = new int[2]; // Setup array
            arrayExample[0] = Processing.IsNumber(Console.ReadLine()); // Add to first element

            Graphical.DelayPrint("\n\tWhat is the second number? ");
            arrayExample[1] = Processing.IsNumber(Console.ReadLine());

            int add = arrayExample[0] + arrayExample[1];
            Graphical.DelayPrint("\n\tYour numbers were entered in the array. " + add.ToString() + " is the sum of the two elements." +
                                 "\n\n\tPress any key to continue: ");
            Console.ReadKey();
        }

        public static void List()
        {
            // TODO
        }

        public static void Struct()
        {
            // TODO
        }
    }
}
