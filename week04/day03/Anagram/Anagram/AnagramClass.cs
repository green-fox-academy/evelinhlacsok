using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class AnagramClass
    {
        public bool IsItAnagram(string firstword, string secondword)
        {
            //making it lowercase
            firstword = firstword.ToLower();
            secondword = secondword.ToLower();

            //making the arrays from the strings 
            char[] array1 = firstword.ToCharArray();
            char[] array2 = secondword.ToCharArray();

            //sorting the arrays
            Array.Sort(array1);
            Array.Sort(array2);

            //turning arrays to strings
            string sorted_firstword = new string(array1);
            string sorted_secondword = new string(array2);

            if (sorted_firstword == sorted_secondword)
            {
                return true;
            }
            return false;
        }
    }
}
