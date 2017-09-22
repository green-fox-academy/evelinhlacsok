using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace Triangles
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            foxDraw.BackgroundColor(Colors.Gold);

            int size = 600;

            foxDraw.DrawLine(0, 0, size, 0);
            foxDraw.DrawLine(size, 0, size/2, size);
            foxDraw.DrawLine(size/2, size, 0, 0);


        }
        private void DrawTriangles (FoxDraw triangles, int size)
        {
            triangles.StrokeColor(Colors.Black);
            triangles.DrawLine(size / 2, 0, size / 4 * 3, size / 2);
            triangles.DrawLine(size / 4 * 3, size / 2, size / 4, size / 2);
            triangles.DrawLine(size / 4, size / 2, size / 2, 0);

            return triangles;
        }
    }
}
