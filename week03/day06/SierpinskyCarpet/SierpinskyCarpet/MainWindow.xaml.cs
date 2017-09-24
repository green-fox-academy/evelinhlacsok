using System;
using System.Windows.Controls;
using GreenFox;
using System.Windows.Media;
using System.Windows;

namespace SierpinskyCarpet
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            foxDraw.BackgroundColor(Colors.Gold);
            double size = 600;
            int level = 4;
            Random random = new Random();

            DrawSquare(foxDraw, canvas, 0, 0, 200, level, RandomColor(random), random);

        }
        public Color RandomColor(Random random)
        {
            return Color.FromArgb((byte)random.Next(255),
                                 (byte)random.Next(255),
                                 (byte)random.Next(255),
                                 (byte)random.Next(255));
        }

        public void DrawSquare(FoxDraw foxDraw, Canvas canvas, double x, double y, double side, int level, Color color, Random random)
        {
            foxDraw.FillColor(RandomColor(random));
            foxDraw.DrawRectangle(x + side, y + side, side, side);

            if (level > 0)
            {
                DrawSquare(foxDraw, canvas, x, y,                           side/3, level - 1, color, random);
                DrawSquare(foxDraw, canvas, x + side, y,                    side/3, level - 1, color, random);
                DrawSquare(foxDraw, canvas, x + 2 * side, y,                side/3, level - 1, color, random);
                DrawSquare(foxDraw, canvas, x, y + side,                    side/3, level - 1, color, random);
                DrawSquare(foxDraw, canvas, x + 2 * side, y + side,         side/3, level - 1, color, random);
                DrawSquare(foxDraw, canvas, x, y + 2 * side,                side/3, level - 1, color, random);
                DrawSquare(foxDraw, canvas, x + side, y + 2 * side,         side/3, level - 1, color, random);
                DrawSquare(foxDraw, canvas, x + 2 * side, y + 2 * side,     side/3, level - 1, color, random);
            }
        }
    }
}
