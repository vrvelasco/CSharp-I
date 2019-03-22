using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_of_Nations
{
    class World
    {
        // Static World Object
        public static World theWorld = new World();

        // Declare field
        List<Nation> _nationList;

        // Constructor
        public World()
        {
            _nationList = new List<Nation>();
        }

        // No properties

        // Add a nation
        public void AddNation(Nation nat)
        {
            _nationList.Add(nat);
        }

        // Get info
        public List<string> GetInfo()
        {
            // Create list of nation paragraph
            List<string> infoList = new List<string>();

            // Add each nation's info to the list
            foreach (Nation n in _nationList)
            {
                infoList.Add(n.GetInfo()); // n.GetInfo -> from Nation.cs
            }

            // Return list of paragraphs
            return infoList;
        }
    }
}
