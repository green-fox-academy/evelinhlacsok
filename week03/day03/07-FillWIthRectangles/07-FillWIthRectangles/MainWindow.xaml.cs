using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace _07_FillWIthRectangles
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        { 
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw four different size and color rectangles.
            foxDraw.FillColor(Colors.Green);
            foxDraw.DrawRectangle(10, 10, 150, 50);

            foxDraw.FillColor(Colors.Magenta);
            foxDraw.DrawRectangle(50, 30, 300, 80);

            foxDraw.FillColor(Colors.Gold);
            foxDraw.DrawRectangle(230, 70, 250, 50);

            foxDraw.FillColor(Colors.MediumAquamarine);
            foxDraw.DrawRectangle(180, 200, 180, 280);
        }
    }
}
