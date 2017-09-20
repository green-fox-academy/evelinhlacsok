using System;
using System.Windows.Controls;
using GreenFox;
using System.Windows.Media;
using System.Windows;

namespace _02_ColoredBox
{
 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // draw a box that has different colored lines on each edge.
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            foxDraw.StrokeColor(Colors.Green);
            var startPoint = new Point(150, 150);
            var endPoint = new Point(450, 150);
            foxDraw.DrawLine(startPoint, endPoint);

            foxDraw.StrokeColor(Colors.Magenta);
            var startPoint2 = new Point(150, 450);
            var endPoint2 = new Point(450, 450);
            foxDraw.DrawLine(startPoint2, endPoint2);

            foxDraw.StrokeColor(Colors.Yellow);
            var startPoint3 = new Point(450, 150);
            var endPoint3 = new Point(450, 450);
            foxDraw.DrawLine(startPoint3, endPoint3);

            foxDraw.StrokeColor(Colors.Aquamarine);
            var startPoint4 = new Point(150, 150);
            var endPoint4 = new Point(150, 450);
            foxDraw.DrawLine(startPoint4, endPoint4);
        }
    }
}
