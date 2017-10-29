using System.Collections.Generic;
using System.Drawing;

namespace MyPaint.Draw.DrawLines
{
 /// <summary>
 /// Рисует лининии
 /// </summary>
    public class DrawLine:DrawShape
    {
        public Dictionary<List<Point>,Color> Lines { get; set; }

        public DrawLine(Graphics graphics, Pen pen, Color colorBrush) : base(graphics, pen, colorBrush)
        {
            Lines =new Dictionary<List<Point>, Color>();

        }

        public void Draw(Point point1, Point point2)
        {
            Graphics.DrawLine(Pen, point1, point2);
            Lines.Add(new List<Point> {point1, point2}, Pen.Color);
        }

        public void DrawByTimer()
        {
            foreach (var item in Lines)
            {
                var itemLine = item.Key;
                var color = item.Value;
                Graphics.DrawLine(new Pen(color), itemLine[0], itemLine[1]);
            }
        }

        public override void Clear()
        {
            Lines = new Dictionary<List<Point>, Color>();
            base.Clear();
        }
    }
}
