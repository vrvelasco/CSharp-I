using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_HW
{
    class FileInput
    {
        public static string fileName = "Default.txt";
        public static string success = "The \"Default.txt\" list file was loaded.";
        public static string failure = "Could not open \"Default.txt\" list file.";

        public static int ReadFile(List<string> shoppingList)
        {
            StreamReader inputFile;

            try // Catch file system errors.
            {
                inputFile = File.OpenText(fileName);

                while (!inputFile.EndOfStream)
                {
                    shoppingList.Add(inputFile.ReadLine());
                }

                // Close the file
                inputFile.Close();

                return 0;
            }
            catch 
            {
                // Display error message
                return -1;
            } 
        }

        public static string ReadFileMessage(int result)
        {
            if (result == 0)
            {
                return success;
            }
                return failure;
        }
    }
}
