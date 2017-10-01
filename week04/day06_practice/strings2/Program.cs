using System;
using System.Collections.Generic;

namespace strings2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";
            string url2 = url.Replace("bots", "odds").Insert(5, ":");

            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crutial component, find out what it is and insert it too!
            // Try to solve it more than once using different string functions!

            Console.WriteLine(url2);


        }
    }
}