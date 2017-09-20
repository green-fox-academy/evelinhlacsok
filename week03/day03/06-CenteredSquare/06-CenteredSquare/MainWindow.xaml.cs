using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace _06_CenteredSquare
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // draw a green 10x10 square to the canvas' center.
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            foxDraw.FillColor(Colors.Gold);
            foxDraw.DrawRectangle(canvas.Width / 2 - 50, canvas.Height / 2 - 50, 50, 50);
        }
    }
}
