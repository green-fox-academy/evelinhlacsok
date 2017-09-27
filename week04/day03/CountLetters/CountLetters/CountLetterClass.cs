using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLetters
{
    public class CountLetterClass
    {
        public Dictionary<char, int>MyLetterCounter(string input)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (dictionary.ContainsKey(letter))
                {
                    dictionary[letter]++;
                }
                else
                {
                    dictionary.Add(letter, 1);
                }
            }
            return dictionary;
        }
    }
}
