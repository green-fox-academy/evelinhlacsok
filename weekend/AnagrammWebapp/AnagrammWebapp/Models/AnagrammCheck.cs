using System;
namespace AnagrammWebapp.Models
{
    public class AnagrammCheck
    {
        public string FirstWord { get; set; }
        public string SecondWord { get; set; }

        public bool IsAnagram()
        {
            char[] firstwordCharArray = FirstWord.ToLower().ToCharArray();
            char[] secondwordCharArray = SecondWord.ToLower().ToCharArray();

            Array.Sort(firstwordCharArray);
            Array.Sort(secondwordCharArray);

            return new string(firstwordCharArray) == new string(secondwordCharArray);
        }
    }
}
