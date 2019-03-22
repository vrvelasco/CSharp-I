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
        public static string ReadFile() // Info is hard coded
        {
            string str = ""; // We'll use this for printing

            StreamReader inputFile;

            try // Catch file system and parse errors.
            {
                inputFile = File.OpenText("ClassInfo.txt");

                while (!inputFile.EndOfStream)
                {
                    str += inputFile.ReadLine() + "\n\t";
                }

                // Close the file
                inputFile.Close();

                return "\t" + str;
            }
            catch (Exception ex)
            {
                // Display error message
                return "\tError reading file: " + ex.Message;
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
                    Console.WriteLine("\tPlease try again: \n\t");
                    str = Console.ReadLine();
                    parsed = false;
                }
            }

            return parsedInt;
        }
    }
}
