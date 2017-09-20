using System;
using System.Windows.Controls;
using GreenFox;
using System.Windows.Media;
using System.Windows;

namespace _03_Diagonals
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw the canvas' diagonals in green.

            foxDraw.StrokeColor(Colors.Green);
            
           var startPoint = new Point(canvas.Width/2, canvas.Height/3);
           var endPoint = new Point(canvas.Width/3*2, canvas.Height/3*2);
           foxDraw.DrawLine(startPoint, endPoint);
            foxDraw.DrawLine(new Point(startPoint.X + 1, startPoint.Y), new Point(endPoint.X + 1, endPoint.Y));

            var startPoint2 = new Point(canvas.Width/3*2, canvas.Height/3*2);
           var endPoint2 = new Point(canvas.Width/3, canvas.Height/3*2);
           foxDraw.DrawLine(startPoint2, endPoint2);

           var startPoint3 = new Point(canvas.Width/3, canvas.Height/3*2);
           var endPoint3 = new Point(canvas.Width/2, canvas.Height / 3);
           foxDraw.DrawLine(startPoint3, endPoint3);
        }
    }
}
