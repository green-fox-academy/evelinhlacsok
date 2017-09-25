using System;
using System.Collections.Generic;

namespace BlogPost
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           /* Create a BlogPost class that has
            an AuthorName
            a Title
            a Text
            a PublicationDate
            Create a few blog post objects:
            "Lorem Ipsum" titled by John Doe posted at "2000.05.04."
            Lorem ipsum dolor sit amet.
            "Wait but why" titled by Tim Urban posted at "2010.10.10."
            A popular long-form, stick-figure-illustrated blog about almost everything.
            "One Engineer Is Trying to Get IBM to Reckon With Trump" titled by William Turton at "2017.03.28."
            Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. 
            When I asked to take his picture outside one of IBM’s New York City offices, he told me that 
            he wasn’t really into the whole organizer profile thing. */
            
            BlogPost blogpost1 = new BlogPost();
            blogpost1.AuthorName = "John Doe";
            blogpost1.Title = "Lorem Ipsum";
            blogpost1.PulbicationDate = "2000.05.04.";
            blogpost1.Text = "Lorem ipsum dolor sit amet.";
            
            BlogPost blogpost2 = new BlogPost();
            blogpost2.AuthorName = "Tim Urban";
            blogpost2.Title = "Wait but why";
            blogpost2.PulbicationDate = "2010.10.10";
            blogpost2.Text = "A popular long-form, stick-figure-illustrated blog about almost everything.";
            
            BlogPost blogpost3 = new BlogPost();
            blogpost3.AuthorName = "William Turton";
            blogpost3.Title = "One Engineer Is Trying to Get IBM to Reckon With Trump";
            blogpost3.PulbicationDate = "2017.03.28.";
            blogpost3.Text =
                "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. " +
                "When I asked to take his picture outside one of IBM’s New York City offices, he told me that " +
                "he wasn’t really into the whole organizer profile thing.";


        }
        class BlogPost
        {
           public string AuthorName;
           public string Title;
           public string Text;
           public string PulbicationDate;
        }
    }
}