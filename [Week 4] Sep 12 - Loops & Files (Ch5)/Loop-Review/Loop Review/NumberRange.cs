using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  
/*  3) Display the range of the number as text in a label:
        a) 100 to 199: One Hundreds
        b) 200 to 299: Two Hundreds
        c) 300 to 399: Three Hundreds
        4) 400 to 499: Four Hundreds
        5) 500 to 599: Five Hundreds */

namespace Loop_Review
{
    class NumberRange
    {
        private int userNumberRange;
        private string range;

        public NumberRange()  // Constructor
        {
            userNumberRange = 0;
        }

        public void setUserNumber(int un)
        {
            userNumberRange = un;
        }

        public string getRange()
        {
            if (userNumberRange >= 100 && userNumberRange <= 199)
            {
                range = "One Hundreds";
            }
            else if (userNumberRange >= 200 && userNumberRange <= 299)
            {
                range = "Two Hundreds";
            }
            else if (userNumberRange >= 300 && userNumberRange <= 399)
            {
                range = "Three Hundreds";
            }
            else if (userNumberRange >= 400 && userNumberRange <= 499)
            {
                range = "Four Hundreds";
            }
            else if (userNumberRange >= 500 && userNumberRange <= 599)
            {
                range = "Five Hundreds";
            }
            return range;
        }
    }
}