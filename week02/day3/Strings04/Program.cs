using System;
using System.Collections.Generic;
using System.Text;

namespace Strings04
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            StringBuilder todo = new StringBuilder(todoText);
            todo = todo.Insert(0, "My todo:\n");
            todo = todo.Insert(todo.Length, "Download games\n");
            StringBuilder todo2 = new StringBuilder(todoText + todo);
            todo2 = todo.Insert(todo.Length, "\tDiablo");
          
           
           // todoText = todoText.Insert(1, "My todo: ");
           // todoText = todoText.Insert(20, " Download games");
            
                    // Add "My todo:" to the beginning of the todoText
                    // Add " - Download games" to the end of the todoText
                    // Add " - Diablo" to the end of the todoText but with indention
        
                    // Expected output:
        
                    // My todo:
                    //  - Buy milk
                    //  - Download games
                    //      - Diablo
        
            Console.WriteLine(todo2);
        }
    }
}