using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_HW
{
    // Declare struct and enum data types at namespace level
    struct Student
    {
        public string name;   // Student name
        public int[] scores; // Array of scores
    }

    enum Test { LoopTest, ArrayTest, ClassTest, FinalExam }

    class Program
    {
        // Declare List of Student as a field at Class level
        public static List<Student> studentList;

        // Declare constants fields at class level
        public const int NAME_INDEX = 0;
        public const int NUM_TEST = 4;
        public static int choice = 0;
        public static bool runButtonClicked = false;

        static void Main(string[] args)
        {
            Graphical.AsciiArt(); // Display cool graphic

            // DelayPrint() gives you a cool text effect
            Graphical.DelayedPrint(Graphical.intro);

            Graphical.Menu(); // Display menu
            Graphical.DelayedPrint("\tPlease make a selection: ");
            choice = Processing.IsNumber(Console.ReadLine());

            while (choice != 4) // 4 Quits program
            {
                if (choice >= 1 && choice <= 3) // Menu option range
                {
                    switch (choice) // Swtich on user's choice
                    {
                        case 1:
                            Processing.RunButton();
                            break;
                        case 2:
                            Processing.SearchLINQButton();
                            break;
                        case 3:
                            Processing.SaveFile();
                            break;
                        default: // Shouldn't get to this point, but just in case
                            Console.WriteLine("\n\tYou broke the program! Back to the drawing board.\nPress any key to continue:");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                    }

                    Graphical.Menu(); // Display menu
                    Graphical.DelayedPrint("\tPlease make a selection: ");
                    choice = Processing.IsNumber(Console.ReadLine());
                }
                else
                {
                    Graphical.DelayedPrint("\n\tInvalid choice. Please try again: ");
                    choice = Processing.IsNumber(Console.ReadLine());
                }
            }

            Graphical.Closed();
        }
    }
}
