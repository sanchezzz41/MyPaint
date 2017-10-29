using System;
using System.Collections.Generic;
using System.Drawing;

namespace MyPaint.Draw.DrawCircles
{
    /// <summary>
    /// Рисует круги
    /// </summary>
    public class DrawCircle : DrawShape
    {
        public Dictionary<List<Point>, Color> Circles { get; set; }
        public Dictionary<List<Point>, Color> FillCircles { get; set; }

        public DrawCircle(Graphics graphics, Pen pen, Color colorBrush) : base(graphics, pen, colorBrush)
        {
            Circles = new Dictionary<List<Point>, Color>();
            FillCircles = new Dictionary<List<Point>, Color>();
        }

        public void Draw(Point point1, Point point2)
        {
            var diametr = (int) Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2)) * 2;
            Graphics.DrawRectangle(Pen, point1.X, point1.Y, 2, 2);
            Graphics.DrawEllipse(Pen, point1.X - diametr / 2, point1.Y - diametr / 2, diametr, diametr);
            Circles.Add(new List<Point> {point1, point2}, Pen.Color);
        }

        public void DrawFill(Point point1, Point point2)
        {
            var diametr = (int) Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2)) * 2;
            Graphics.FillEllipse(Brush, point1.X - diametr / 2, point1.Y - diametr / 2, diametr, diametr);
            FillCircles.Add(new List<Point> {point1, point2}, BrushColor);
        }

        public void DrawByTimer()
        {
            foreach (var item in Circles)
            {
                var points = item.Key;
                var color = item.Value;
                var point1 = points[0];
                var point2 = points[1];
                var diametr = (int) Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2)) * 2;
                Graphics.DrawRectangle(new Pen(color), point1.X, point1.Y, 2, 2);
                Graphics.DrawEllipse(new Pen(color), point1.X - diametr / 2, point1.Y - diametr / 2, diametr, diametr);
            }
            foreach (var item in FillCircles)
            {
                var points = item.Key;
                var color = item.Value;
                var point1 = points[0];
                var point2 = points[1];
                var diametr = (int) Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2)) * 2;
                Graphics.FillEllipse(new SolidBrush(color), point1.X - diametr / 2, point1.Y - diametr / 2, diametr,
                    diametr);
            }
        }

        public override void Clear()
        {
            FillCircles = new Dictionary<List<Point>, Color>();
            Circles = new Dictionary<List<Point>, Color>();
            base.Clear();
        }
    }
}
