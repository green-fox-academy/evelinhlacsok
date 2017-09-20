using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace _08_SquarePositioning
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a square drawing function that takes 2 parameters:
            // the x and y coordinates of the square's top left corner
            // and draws a 50x50 square from that point.
            // draw 3 squares with that function.            

            Squares(foxDraw, 30, 40);
            Squares(foxDraw, 80, 130);
            Squares(foxDraw, 240, 210);
            Squares(foxDraw, 115, 30);
        }
        private void Squares (FoxDraw SquareMaker, int x, int y)
        {
            SquareMaker.FillColor(Colors.Gold);
            SquareMaker.DrawRectangle(x, y, 50, 50);
        }
    }
}
