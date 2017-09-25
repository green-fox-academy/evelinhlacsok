using System;
using System.Collections.Generic;

namespace PostIt
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            /*Create a PostIt a struct that has
            a BackgroundColor
            a Text on it
            a TextColor
            Create a few example post-it objects:
            an orange with blue text: "Idea 1"
            a pink with black text: "Awesome"
            a yellow with green text: "Superb!"*/
            
            PostIt postit1 = new PostIt();
            postit1.BackgroundColor = "orange";
            postit1.Text = "Idea 1";
            postit1.TextColor = "blue";
            
            PostIt postit2 = new PostIt();
            postit2.BackgroundColor = "pink";
            postit2.Text = "Awesome";
            postit2.TextColor = "black";
            
            PostIt postit3 = new PostIt();
            postit3.BackgroundColor = "yellow";
            postit3.Text = "Superb!";
            postit3.TextColor = "green";

        }
        public struct PostIt
        {
            public string BackgroundColor;
            public string Text;
            public string TextColor;
        }
    }
}