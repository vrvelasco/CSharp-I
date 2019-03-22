using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Console_HW
{
    class Processing // (Bonus -- First Class)
    {
        public const int NAME_INDEX = 0;
        public const int NUM_TEST = 4;
        private static string saveStr = "";

        // Read scores from CSV file
        public static bool readScores(string fileName)
        {
            // Declare file and string variables
            StreamReader csvFile;
            string csvLine;
            char[] delim = { ',' };
            string[] tokens;

            // Catch file system errors
            try
            {
                // Open CSV file
                csvFile = File.OpenText(fileName);

                // Create Student List
                Program.studentList = new List<Student>();

                // Read to end of file
                while (!csvFile.EndOfStream)
                {
                    // Read one line
                    csvLine = csvFile.ReadLine();

                    // Split line into tokens
                    tokens = csvLine.Split(delim);

                    // Create a Student and populate from CSV
                    Student student = new Student();
                    student.name = tokens[NAME_INDEX];
                    student.scores = new int[NUM_TEST];

                    for (int t = 0; t < NUM_TEST; t++)
                    {
                        student.scores[t] = int.Parse(tokens[1 + t]);
                    }

                    // Add Student to List
                    Program.studentList.Add(student);
                }

                // Close CSV file
                csvFile.Close();

                return true;
            }
            catch (Exception ex)
            {
                // Display error message
                Graphical.DelayedPrint(ex.Message);
                return false;
            }
        }

        // Calculate and display average scores
        public static void DisplayAverages(List<Student> stuList)
        {
            // Calculate average score for all students
            foreach (Student student in stuList)
            {
                // Calculate average score for one student
                double total = 0;

                for (Test t = Test.LoopTest; t <= Test.FinalExam; t++)
                {
                    total += student.scores[(int)t];
                }

                double average = total / NUM_TEST;

                // Display student name and average
                Graphical.DelayedPrint("\n\t" + student.name + "\t" + average.ToString("n1"));
                saveStr += student.name + "\t[ " + average.ToString("n1") + " ] ";
            }
        }

        public static void RunButton()
        {
            // Get scores filename
            string fileName = "Scores.csv";

            Graphical.DelayedPrint("\n\tThis is from the \"" + fileName + "\" file.\n\n\tName:\tScore:");
            // Read scores file
            if (readScores(fileName))
            {
                // Process and display scores
                DisplayAverages(Program.studentList);
                Program.runButtonClicked = true;
            }
            else
            {
                Graphical.DelayedPrint("Error reading file: " + fileName);
            }

            Graphical.DelayedPrint("\n\n\tPress any key to continue: ");
            Console.ReadKey();
            saveStr = "";
        }

        // Search for students by name
        // Display names and averages
        public static void SearchLINQButton()
        {
            // Declare variables
            string searchName;

            if (Program.runButtonClicked)
            {
                // Read search term from TextBox
                Graphical.DelayedPrint("\n\tPlease enter the (case-sensitive) search term: ");
                searchName = Console.ReadLine();//searchTextBox.Text;

                // Search for student in struct in list
                // using LINQ extension method with lambda expression
                var foundStuVar = Program.studentList.Where(stuStruct => stuStruct.name.Contains(searchName));

                // Copy structs from var to List
                List<Student> foundStuList = new List<Student>();

                foreach (Student foundStuStruct in foundStuVar)
                {
                    foundStuList.Add(foundStuStruct);
                }

                // Calculate average and display results
                Graphical.DelayedPrint("\n\tSearch Results: \n");
                DisplayAverages(foundStuList);

                Graphical.DelayedPrint("\n\n\tPress any key to continue: ");
                Console.ReadKey();
            }
            else
            {
                Graphical.DelayedPrint("\n\tPlease load a file first.\n\n\tPress any key to continue: ");
                Console.ReadKey();
            }
        }

        public static int IsNumber(string userString)
        {
            string str = userString;
            int parsedInt = 0;
            bool parsed = false;

            while (!parsed) // Loop until the number is greater than zero
            {
                if (int.TryParse(str, out parsedInt)) // Is it a valid integer
                {
                    // Success!
                    parsed = true;
                }
                else
                {
                    Graphical.DelayedPrint("\n\tInvalid choice. Please try again: ");
                    str = Console.ReadLine();
                    parsed = false;
                }
            }

            return parsedInt;
        }

        public static void SaveFile()
        {
            string saveFileName = "Results.txt";
            StreamWriter saveFile;

            try
            {
                saveFile = File.CreateText(saveFileName);
                saveFile.WriteLine("Name:\t[ Avg: ]");
                saveFile.WriteLine("================");
                saveFile.WriteLine(saveStr);
                saveFile.Close();
                saveStr = "";

                Graphical.DelayedPrint("\n\tYour file was saved successfully!");
                Graphical.DelayedPrint("\n\n\tPress any key to continue: ");
                Console.ReadKey();
            }
            catch
            {
                Graphical.DelayedPrint("\n\tUnable to save the file. Please try again.");
                Graphical.DelayedPrint("\n\n\tPress any key to continue: ");
                Console.ReadKey();
            }


        }
    }
}
