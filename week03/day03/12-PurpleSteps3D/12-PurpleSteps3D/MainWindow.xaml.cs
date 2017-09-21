using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace _12_PurpleSteps3D
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            int x = 10;
            for (int i = 0; x < canvas.Width * 2 / 3; i++)
            {
                for (int j = 0; x < canvas.Height * 2 / 3; j++)
                {
                    foxDraw.FillColor(Colors.Purple);
                    foxDraw.StrokeColor(Colors.Black);
                    foxDraw.DrawRectangle(x, x, x, x);
                    x *= 2;
                }
            }

        }
    }
}
