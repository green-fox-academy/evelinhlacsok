using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;


namespace Checkerboard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // fill the canvas with a checkerboard pattern.

            foxDraw.BackgroundColor(Colors.Gold);

            double size = 75;
            double x = 0;
            double y = 0;
            //Squares(foxDraw, a, b);
            //Squares(foxDraw, a+75, b);
            //Squares(foxDraw, a, b+75);
            //Squares(foxDraw, a+75, b+75);

            for (int i = 0; i < 8; i++)
            {
                    if (i % 2 == 1)
                    {
                         x += size;
                    }
                for (int j = 0; j < 4; j++)
                {
                    foxDraw.FillColor(Colors.Black);
                    foxDraw.DrawRectangle(x, y, size, size);
                    x += 2 * size;
                }
                x = 0;
                y += size;
            }

        }
    }
}
