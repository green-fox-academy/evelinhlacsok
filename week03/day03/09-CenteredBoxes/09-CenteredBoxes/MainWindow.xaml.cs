using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace _09_CenteredBoxes
{
  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var threeSquares = new FoxDraw(canvas);
            // create a square drawing function that takes 1 parameter:
            // the square size
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.

            DrawSquare(threeSquares, 250);
            DrawSquare(threeSquares, 110);
            DrawSquare(threeSquares, 26);
        }
        private void DrawSquare(FoxDraw squarez, int size)
        {
            squarez.FillColor(Colors.Aquamarine);
            squarez.DrawRectangle((canvas.Width-size)/2, (canvas.Height-size)/2, size, size);
        }
    }
}
