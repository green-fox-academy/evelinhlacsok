using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;


namespace _04_GoToCenter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // draw 3 lines with that function.

            

            DrawLine(foxDraw, 30, 40);
            DrawLine(foxDraw, 80, 130);
            DrawLine(foxDraw, 300, 450);

        }

        private void DrawLine(FoxDraw intothecenter, int x, int y)
        {
            intothecenter.StrokeColor(Colors.Green);
            intothecenter.DrawLine(new Point(x, y), new Point(canvas.Width / 2, canvas.Height / 2));

        }

    }
    
}
