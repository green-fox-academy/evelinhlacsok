using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace _10_RainbowBoxes
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a square drawing function that takes 2 parameters:
            // the square size, and the fill color,
            // and draws a square of that size and color to the center of the canvas.
            // create a loop that fills the canvas with rainbow colored squares.

            DrawSquare(foxDraw, 250, Colors.Magenta);
            DrawSquare(foxDraw, 150, Colors.Gold);
            DrawSquare(foxDraw, 60, Colors.Aquamarine);

        }
        private void DrawSquare (FoxDraw squarez, int size, Color color)
        {
            squarez.FillColor(color);
            squarez.DrawRectangle((canvas.Width-size)/2, (canvas.Height-size)/2, size, size);

        }
    }
}
