using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace _05_Horizontal1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a 50 long horizontal line from that point.
            // draw 3 lines with that function.

            DrawLine(foxDraw, 40, 50);
            DrawLine(foxDraw, 240, 180);
            DrawLine(foxDraw, 300, 450);

        }
        private void DrawLine (FoxDraw Horizontal, int x, int y)
        {
            Horizontal.StrokeColor(Colors.Magenta);
            Horizontal.DrawLine(new Point(x, y), new Point(x + 50, y));
        }
    }
}
