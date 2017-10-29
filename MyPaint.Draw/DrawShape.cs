using System.Drawing;

namespace MyPaint.Draw
{
    /// <summary>
    /// Интерфейс для рисования
    /// </summary>
    public abstract class  DrawShape
    {
        /// <summary>
        /// Возвращает методы и свойства необходимые для рисования
        /// </summary>
        public Graphics Graphics { get; }

        /// <summary>
        /// 
        /// </summary>
        public Pen Pen { get; }
        /// <summary>
        /// Кисть
        /// </summary>
        public Brush Brush { get; set; }

        public Color BrushColor { get; set; }

        /// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Object" />.</summary>
        public DrawShape(Graphics graphics, Pen pen, Color colorBrush)
        {
            Graphics = graphics;
            Pen = pen;
            Brush = new SolidBrush(colorBrush);
            BrushColor = colorBrush;
        }


        /// <summary>
        /// Установить цвет ручки
        /// </summary>
        /// <param name="color"></param>
        public virtual void SetPenColor(Color color)
        {
            Pen.Color = color;
        }

        /// <summary>
        /// Установить цвет кисти
        /// </summary>
        /// <param name="color"></param>
        public  virtual void SetBrushColor(Color color)
        {
            Brush = new SolidBrush(color);
            BrushColor = color;
        }

        public virtual void Clear()
        {
            Graphics.Clear(Color.White);
        }
    }
}
