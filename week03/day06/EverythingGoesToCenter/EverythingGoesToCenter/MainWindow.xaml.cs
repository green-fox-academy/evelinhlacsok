using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace EverythingGoesToCenter
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
            // fill the canvas with lines from the edges, every 20 px, to the center.

            int x = 0;
            int y = 0;
            for (int i = 0; i <= 600; i+=20)
            {
                ToTheCenter(foxDraw, 0, i);
            }
            for (int j = 0; j <= 600; j+=20)
            {
                ToTheCenter(foxDraw, j, 0);
            }
            for (int k = 0; k <= 600; k+=20)
            {
                ToTheCenter(foxDraw, k, 600);
            }
            for (int l = 0; l <= 600; l+=20)
            {
                ToTheCenter(foxDraw, 600, l);
            }
            
        }

        public void ToTheCenter(FoxDraw lines, int x, int y)
        {
            var foxDraw = new FoxDraw(canvas);
            var startPoint = new Point(x, y);
            var centerPoint = new Point(canvas.Width / 2, canvas.Height / 2);
            foxDraw.StrokeColor(Colors.BlueViolet);
            foxDraw.DrawLine(startPoint, centerPoint);
            
        }
    }
}
