using System;
using System.Collections.Generic;
using System.Drawing;

namespace MyPaint.Draw.DrawTriangles
{
    /// <summary>
    /// Рисует треугольник
    /// </summary>
    public class DrawTriangle:DrawShape
    {
        /// <summary>
        /// Список фигур для простой отрисовки
        /// </summary>
        public Dictionary<List<Point>, Color> Shapes { get; set; }

        /// <summary>
        /// Список фигур для закрашивания
        /// </summary>
        public Dictionary<List<Point>, Color> FillShapes { get; set; }


        public DrawTriangle(Graphics graphics, Pen pen, Color brush):base(graphics,pen,brush)
        {
            Shapes = new Dictionary<List<Point>, Color>();
            FillShapes = new Dictionary<List<Point>, Color>();
        }

        public void Draw(Point point1, Point point2, Point point3)
        {
            Graphics.DrawPolygon(Pen, new[] {point1, point2, point3});
            Shapes.Add(new List<Point> {point1, point2, point3}, Pen.Color);
        }

        public void DrawFill(Point point1, Point point2, Point point3)
        {
            Graphics.FillPolygon(Brush, new[] {point1, point2, point3});
            FillShapes.Add(new List<Point> {point1, point2, point3}, BrushColor);
        }

        public void DrawByTimer()
        {
            foreach (var item in Shapes)
            {
                var points = item.Key;
                var color = item.Value;
                Graphics.DrawPolygon(new Pen(color), new[] {points[0], points[1], points[2]});
            }
            foreach (var item in FillShapes)
            {
                var points = item.Key;
                var color = item.Value;
                Graphics.FillPolygon(new SolidBrush(color), new[] {points[0], points[1], points[2]});
            }
        }

        public override void Clear()
        {
            FillShapes = new Dictionary<List<Point>, Color>();
            Shapes = new Dictionary<List<Point>, Color>();
            base.Clear();
        }
    }
}
