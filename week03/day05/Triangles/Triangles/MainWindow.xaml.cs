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
            Random random = new Random();

            DrawTriangles(foxDraw, size, 0, 0, level, RandomColor(random));
            //  DrawTriangles.DrawLine(foxDraw, size, 0, size / 2, size);
            //  DrawTriangles.DrawLine(foxDraw, size / 2, size, 0, 0);


        }
        public Color RandomColor(Random random)
        {
            return Color.FromArgb((byte)random.Next(255),
                                 (byte)random.Next(255),
                                 (byte)random.Next(255),
                                 (byte)random.Next(255));
        }
        private void DrawTriangles(FoxDraw triangles, int size, int x, int y, int level, Color color)
        {
            if (level > 0)
            {
                triangles.StrokeColor(color);
                Point top = new Point(x + size / 2, y);
                Point right = new Point(x + size / 3 * 4, y + size / 2);
                Point left = new Point(x + size / 4, y + size / 2);
                

                triangles.DrawLine(x + size / 2, y, x + size / 4 * 3, y + size / 2);
                triangles.DrawLine(x + size / 4 * 3, y + size / 2, x + size / 4, y + size / 2);
                triangles.DrawLine(x + size / 4, y + size / 2, x + size / 2, y);

                triangles.DrawPolygon(top, right, left);
               
                

                // TODO: nagy haromszog

                triangles.DrawLine(x, y, x + size, y);
                triangles.DrawLine(x + size, y, x + size / 2, y + size);
                triangles.DrawLine(x + size / 2, y + size, x, y);

                DrawTriangles(triangles, size / 2, x, y, level - 1, color);
                DrawTriangles(triangles, size / 2, x + size / 2, y, level - 1, color);
                DrawTriangles(triangles, size / 2, x + size / 4, y + size / 2, level - 1, color);

            }

        }
    }
}
