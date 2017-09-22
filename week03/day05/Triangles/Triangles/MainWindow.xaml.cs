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
            int level = 5;
            int size = 600;

            DrawTriangles(foxDraw, size, 0, 0, level);
          //  DrawTriangles.DrawLine(foxDraw, size, 0, size / 2, size);
          //  DrawTriangles.DrawLine(foxDraw, size / 2, size, 0, 0);


        }
        private void DrawTriangles(FoxDraw triangles, int size, int x, int y, int level)
        {
            if (level > 0)
            {
                triangles.DrawLine(x + size / 2, y, x + size / 4 * 3, y + size / 2);
                triangles.DrawLine(x + size / 4 * 3, y + size / 2, x + size / 4, y + size / 2);
                triangles.DrawLine(x + size / 4, y + size / 2, x + size / 2, y);

                // TODO: nagy haromszog

                //triangles.DrawLine(x, y, size, y);
                //triangles.DrawLine(size, y, x + size / 2, y+size);
                //triangles.DrawLine(x + size / 2, y+size, x, y);

                DrawTriangles(triangles, size / 2, x, y, level - 1);
                DrawTriangles(triangles, size / 2, x + size / 2, y, level - 1);
                DrawTriangles(triangles, size / 2, x + size / 4, y + size / 2, level -1);

            }
        }
    }
}
