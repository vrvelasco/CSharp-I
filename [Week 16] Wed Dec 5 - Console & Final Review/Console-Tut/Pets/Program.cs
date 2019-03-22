using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pets
{
    class Program
    {
        private static bool ReadFile(string fileName, List<Pet> pets)
        {
            char[] delim = { ',' };
            const int PET_NAME = 0; // Token Indexes
            const int OWNER_NAME = 1;
            const int OWNER_PHONE = 2;

            // Catch exceptions
            try
            {
                // Open file
                StreamReader petFile = File.OpenText(fileName);

                // Read file
                while (!petFile.EndOfStream)
                {
                    // Read one line
                    string line = petFile.ReadLine();

                    // Split line into tokens
                    string[] tokens = line.Split(delim);
                    string petName = tokens[PET_NAME];
                    string ownerName = tokens[OWNER_NAME];
                    string ownerPhone = tokens[OWNER_PHONE];

                    // Create Pet object
                    Pet pet = new Pet(petName);
                    pet.Owner = ownerName;
                    pet.Phone = ownerPhone;

                    // Add pet to list
                    pets.Add(pet);
                }

                // Close file
                petFile.Close();

                return true;
            }
            catch (Exception ex)
            {
                Console.Write("DEBUG: ");
                Console.WriteLine(ex.Message);

                return false;
            }
        }
        static void Main(string[] args)
        {
            // Declare and create Pet List
            List<Pet> petList = new List<Pet>();

            // Input and validate file path/name
            if (args.Length == 1 && args[0].Length > 0)
            {
                // Read file
                if (ReadFile(args[0], petList))
                {
                    // Display all pet names
                    Console.WriteLine(petList.Count.ToString() + " pets were read.");

                    foreach (Pet p in petList)
                    {
                        Console.WriteLine(p.Name);
                    }

                    // Prompt for pet name to search
                    Console.Write("Search for pet: ");
                    string searchPet = Console.ReadLine();

                    // Search list using LINQ query
                    var foundPets = petList.Where(p => p.Name.StartsWith(searchPet));

                    // Display search results
                    foreach (Pet p in foundPets)
                    {
                        Console.WriteLine(p.Name + "\t" + p.Owner + "\t" + p.Phone);
                    }
                }
                else
                {
                    Console.WriteLine("Error reading file.");
                }
            }
            else
            {
                Console.WriteLine("Please enter file name/path.");
            }

            Console.WriteLine("Press Enter to continue: ");
            string enter = Console.ReadLine();
        }
    }
}
