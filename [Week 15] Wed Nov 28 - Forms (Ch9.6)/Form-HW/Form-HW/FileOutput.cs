using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_HW
{
    class FileOutput
    {
        public static string fileName = "Saved.txt";
        public static string success = "The \"Saved.txt\" list file was saved.";
        public static string failure = "The list file was not saved successfully.";
        public static int count;

        public static int SaveFile(List<string> shoppingList)
        {
            StreamWriter inputFile;
            count = shoppingList.Count;

            try // Catch file system errors.
            {
                inputFile = File.CreateText(fileName);

                inputFile.WriteLine("SHOPPING LIST\n");

                shoppingList.ForEach(inputFile.WriteLine);

                inputFile.WriteLine("\nTotal Items: " + count.ToString());

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
        public static string SaveFileMessage(int result)
        {
            if (result == 0)
            {
                return success;
            }
            return failure;
        }
    }
}
