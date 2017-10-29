using System.Collections.Generic;
using System.Drawing;

namespace MyPaint.Draw.DrawRectangles
{
    public class DrawRectangle:DrawShape
    {
        public Dictionary<Rectangle,Color> Rectangles { get; set; }
        public Dictionary<Rectangle,Color> FillRectangles { get; set; }


        public DrawRectangle(Graphics graphics, Pen pen, Color colorBrush) : base(graphics, pen, colorBrush)
        {
            Rectangles = new Dictionary<Rectangle, Color>();
            FillRectangles = new Dictionary<Rectangle, Color>();
        }

        public void Draw(Point point1, Point point2)
        {
            var rectangle = Check(point1, point2);
            Graphics.DrawRectangle(Pen,rectangle);
            Rectangles.Add(rectangle, Pen.Color);
        }

        public void FillDraw(Point point1, Point point2)
        {
            var rectangle = Check(point1, point2);
            Graphics.FillRectangle(Brush, rectangle);
            FillRectangles.Add(rectangle, BrushColor);
        }

        public void DrawByTimer()
        {
            foreach (var item in Rectangles)
            {
                Graphics.DrawRectangle(new Pen(item.Value), item.Key);
            }
            foreach (var item in FillRectangles)
            {
                Graphics.FillRectangle(new SolidBrush(item.Value), item.Key);
            }
        }

        public override void Clear()
        {
            Rectangles = new Dictionary<Rectangle, Color>();
            FillRectangles = new Dictionary<Rectangle, Color>();
            base.Clear();
        }

        private Rectangle Check(Point point1, Point point2)
        {
            var rectangle = new Rectangle();
            if (point2.X > point1.X)
            {
                if (point1.Y > point2.Y)
                    //Правая верхняя четверть
                    rectangle = new Rectangle(point1.X, point2.Y, point2.X - point1.X, point1.Y - point2.Y);
                else
                    //Правая нижняя четверть
                    rectangle = new Rectangle(point1.X, point1.Y, point2.X - point1.X, point2.Y - point1.Y);
            }
            else
            {
                if (point1.Y > point2.Y)
                    //Левая верхняя четверть
                    rectangle = new Rectangle(point2.X, point2.Y, point1.X - point2.X, point1.Y - point2.Y);
                else
                    //Левая нижняя четверть
                    rectangle = new Rectangle(point2.X, point1.Y, point1.X - point2.X, point2.Y - point1.Y);
            }
            return rectangle;
        }
    }
}
