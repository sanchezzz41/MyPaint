using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MyPaint.Draw.DrawCircles;
using MyPaint.Draw.DrawLines;
using MyPaint.Draw.DrawRectangles;
using MyPaint.Draw.DrawTriangles;
using MyPaint.Draw.Points;

namespace MyPaint
{
    public partial class Form1 : Form
    {
        public event Action<Color> _changeMainColor;
        public event Action<Color> _changeBrushColor;
        private int _count;

        private DrawLine _drawLine;
        private DrawRectangle _drawRectangles;
        private DrawPoint _drawPoint;
        private DrawCircle _drawCircle;
        private DrawTriangle _drawTriangle;

        private List<Point> _points;
        public Form1()
        {
            InitializeComponent();
            InitializeOptions();
        }

        private void InitializeOptions()
        {
            _points = new List<Point>();
            ClientSize = new Size(1280, 800);

            var pen = new Pen(Color.Black);
            var brushColor = Color.Black;
            var graphics = CreateGraphics();

            //Иницилизация наших классов
            _drawLine = new DrawLine(graphics, pen, brushColor);
            _drawRectangles=new DrawRectangle(graphics,pen, brushColor);
            _drawPoint = new DrawPoint(CreateGraphics(), pen, brushColor);
            _drawCircle = new DrawCircle(graphics, pen, brushColor);
            _drawTriangle = new DrawTriangle(graphics, pen, brushColor);

            EventMainColor();
            EventBrushColor();

            mainColorButton.BackColor = pen.Color;
            brushColorButton.BackColor = brushColor;

            _count = 0;

            PositionLabel.Location = new Point(this.Width - 125, this.Height - 70);
        
            TimerDraw.Start();
        }

        private void EventMainColor()
        {
            _changeMainColor += _drawLine.SetPenColor;
            _changeMainColor += _drawRectangles.SetPenColor;
            _changeMainColor += _drawCircle.SetPenColor;
            _changeMainColor += _drawPoint.SetPenColor;
            _changeMainColor += _drawTriangle.SetPenColor;
        }

        private void EventBrushColor()
        {
            _changeBrushColor += _drawLine.SetBrushColor;
            _changeBrushColor += _drawRectangles.SetBrushColor;
            _changeBrushColor += _drawCircle.SetBrushColor;
            _changeBrushColor += _drawPoint.SetBrushColor;
            _changeBrushColor += _drawTriangle.SetBrushColor;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            var mouseEv = (MouseEventArgs) e;
            if (mouseEv.Button == MouseButtons.Left)
            {
                _points.Add(new Point(mouseEv.X, mouseEv.Y));
                _count++;
                if (IsPoint.Checked)
                {
                    _drawPoint.Draw(_points.Last());
                    _points = new List<Point>();
                    _count = 0;
                    return;
                }
                if (_count == 3)
                {
                    if (IsTriangle.Checked)
                    {
                        _drawTriangle.Draw(_points[0], _points[1], _points[2]);
                        if (IsFill.Checked)
                            _drawTriangle.DrawFill(_points[0], _points[1], _points[2]);
                    }
                    _count = 0;
                    _points=new List<Point>();
                }
                if (_count==2 && !IsTriangle.Checked)
                {
                    var point1 = _points[0];
                    var point2 = _points[1];
                    if (IsLine.Checked)
                        _drawLine.Draw(point1, point2);
                    if (IsRectangle.Checked)
                    {
                        _drawRectangles.Draw(point1, point2);
                        if (IsFill.Checked)
                            _drawRectangles.FillDraw(point1, point2);
                    }
                     
                    if (IsCircle.Checked)
                    {
                        _drawCircle.Draw(point1, point2);
                        if(IsFill.Checked)
                            _drawCircle.DrawFill(point1, point2);
                    };

                    _points = new List<Point>();
                    _count = 0;
                }
            }
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            var mouseEv = (MouseEventArgs) e;
            if (mouseEv.Button == MouseButtons.Right)
            {
                _drawLine.Clear();
                _drawCircle.Clear();
                _drawTriangle.Clear();
                _drawRectangles.Clear();
                _drawPoint.Clear();
            }
        }

        private void Move_Mouse(object sender, MouseEventArgs e)
        {
            PositionLabel.Text = $"({e.X}:{e.Y})";
        }

        private void TimerDraw_Tick(object sender, EventArgs e)
        {
            _drawLine.DrawByTimer();
            _drawRectangles.DrawByTimer();
            _drawPoint.DrawByTimer();
            _drawCircle.DrawByTimer();
            _drawTriangle.DrawByTimer();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            var form = (Form1) sender;
            PositionLabel.Location = new Point(form.Width - 125, form.Height - 70);
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.FullOpen = true;
            colorDialog1.ShowHelp = true;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                var color = colorDialog1.Color;
                mainColorButton.BackColor = color;
                _changeMainColor(color);
            }
        }

        private void brushColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.FullOpen = true;
            colorDialog1.ShowHelp = true;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                var color = colorDialog1.Color;
                brushColorButton.BackColor = color;
                _changeBrushColor(color);
            }
        }
    }
}
