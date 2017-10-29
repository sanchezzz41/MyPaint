using System.Collections.Generic;
using System.Drawing;

namespace MyPaint.Draw.Points
{
    public class DrawPoint:DrawShape
    {
        public Dictionary<Point,Color> Points{ get; set; }

        public DrawPoint(Graphics graphics, Pen pen, Color colorBrush) : base(graphics, pen, colorBrush)
        {
            Points=new Dictionary<Point, Color>();
        }

        public void Draw(Point point)
        {
            var rectangle = new Rectangle(point.X,point.Y,1,1);
            Graphics.DrawRectangle(Pen, rectangle);
            Points.Add(new Point(rectangle.X, rectangle.Y), Pen.Color);
        }

        public void DrawByTimer()
        {
            foreach (var item in Points)
            {
                var rectangle = new Rectangle(item.Key.X, item.Key.Y, 1, 1);
                Graphics.DrawRectangle(new Pen(item.Value), rectangle);
            }
        }

        public override void Clear()
        {
            Points = new Dictionary<Point, Color>();
            base.Clear();
        }
    }
}
