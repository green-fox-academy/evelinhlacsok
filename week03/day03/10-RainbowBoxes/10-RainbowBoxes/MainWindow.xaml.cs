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
            Random random = new Random();
            // create a square drawing function that takes 2 parameters:
            // the square size, and the fill color,
            // and draws a square of that size and color to the center of the canvas.
            // create a loop that fills the canvas with rainbow colored squares.

            for (int size = 600;  size>= 0; size -= 20)
            {
                DrawSquare(foxDraw, size, RandomColor(random));
            }

        }
         public Color RandomColor (Random random)
        {
            return Color.FromArgb((byte)random.Next(255),
                                 (byte)random.Next(255),
                                 (byte)random.Next(255),
                                 (byte)random.Next(255));
        }

        private void DrawSquare (FoxDraw squarez, int size, Color color)
        {
            squarez.FillColor(color);
            squarez.StrokeColor(Colors.White);
            squarez.DrawRectangle((canvas.Width-size)/2, (canvas.Height-size)/2, size, size);

        }
    }
}
