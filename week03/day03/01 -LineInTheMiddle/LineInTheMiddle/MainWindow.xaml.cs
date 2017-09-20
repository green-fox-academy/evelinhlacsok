using System;
using System.Windows.Controls;
using GreenFox;
using System.Windows.Media;
using System.Windows;

namespace LineInTheMiddle
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //  draw a red horizontal line to the canvas' middle.
            //  draw a green vertical line to the canvas' middle.

            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            foxDraw.StrokeColor(Colors.Green);
            var startPoint = new Point(300, 0);
            var endPoint = new Point(300, 600);
            foxDraw.DrawLine(startPoint, endPoint);

            foxDraw.StrokeColor(Colors.Red);
            var startPoint2 = new Point(0, 300);
            var endPoint2 = new Point(600, 300);
            foxDraw.DrawLine(startPoint2, endPoint2);
        }
    }
}
