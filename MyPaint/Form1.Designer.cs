namespace MyPaint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.TimerDraw = new System.Windows.Forms.Timer(this.components);
            this.IsLine = new System.Windows.Forms.RadioButton();
            this.IsRectangle = new System.Windows.Forms.RadioButton();
            this.IsPoint = new System.Windows.Forms.RadioButton();
            this.IsCircle = new System.Windows.Forms.RadioButton();
            this.IsTriangle = new System.Windows.Forms.RadioButton();
            this.IsFill = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainColorButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.brushColorButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionLabel.Location = new System.Drawing.Point(580, 476);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(126, 26);
            this.PositionLabel.TabIndex = 0;
            this.PositionLabel.Text = "PointsLabel";
            // 
            // TimerDraw
            // 
            this.TimerDraw.Tick += new System.EventHandler(this.TimerDraw_Tick);
            // 
            // IsLine
            // 
            this.IsLine.AutoSize = true;
            this.IsLine.Location = new System.Drawing.Point(12, 22);
            this.IsLine.Name = "IsLine";
            this.IsLine.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IsLine.Size = new System.Drawing.Size(57, 17);
            this.IsLine.TabIndex = 2;
            this.IsLine.TabStop = true;
            this.IsLine.Text = "Линия";
            this.IsLine.UseVisualStyleBackColor = true;
            // 
            // IsRectangle
            // 
            this.IsRectangle.AutoSize = true;
            this.IsRectangle.Location = new System.Drawing.Point(12, 45);
            this.IsRectangle.Name = "IsRectangle";
            this.IsRectangle.Size = new System.Drawing.Size(67, 17);
            this.IsRectangle.TabIndex = 3;
            this.IsRectangle.TabStop = true;
            this.IsRectangle.Text = "Квадрат";
            this.IsRectangle.UseVisualStyleBackColor = true;
            // 
            // IsPoint
            // 
            this.IsPoint.AutoSize = true;
            this.IsPoint.Location = new System.Drawing.Point(12, 68);
            this.IsPoint.Name = "IsPoint";
            this.IsPoint.Size = new System.Drawing.Size(55, 17);
            this.IsPoint.TabIndex = 4;
            this.IsPoint.TabStop = true;
            this.IsPoint.Text = "Точка";
            this.IsPoint.UseVisualStyleBackColor = true;
            // 
            // IsCircle
            // 
            this.IsCircle.AutoSize = true;
            this.IsCircle.Location = new System.Drawing.Point(12, 91);
            this.IsCircle.Name = "IsCircle";
            this.IsCircle.Size = new System.Drawing.Size(48, 17);
            this.IsCircle.TabIndex = 5;
            this.IsCircle.TabStop = true;
            this.IsCircle.Text = "Круг";
            this.IsCircle.UseVisualStyleBackColor = true;
            // 
            // IsTriangle
            // 
            this.IsTriangle.AutoSize = true;
            this.IsTriangle.Location = new System.Drawing.Point(12, 114);
            this.IsTriangle.Name = "IsTriangle";
            this.IsTriangle.Size = new System.Drawing.Size(153, 17);
            this.IsTriangle.TabIndex = 6;
            this.IsTriangle.TabStop = true;
            this.IsTriangle.Text = "Треугольник по 3 точкам";
            this.IsTriangle.UseVisualStyleBackColor = true;
            // 
            // IsFill
            // 
            this.IsFill.AutoSize = true;
            this.IsFill.Location = new System.Drawing.Point(12, 163);
            this.IsFill.Name = "IsFill";
            this.IsFill.Size = new System.Drawing.Size(69, 17);
            this.IsFill.TabIndex = 7;
            this.IsFill.Text = "Заливка";
            this.IsFill.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.brushColorButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mainColorButton);
            this.panel1.Controls.Add(this.IsPoint);
            this.panel1.Controls.Add(this.IsFill);
            this.panel1.Controls.Add(this.IsLine);
            this.panel1.Controls.Add(this.IsTriangle);
            this.panel1.Controls.Add(this.IsRectangle);
            this.panel1.Controls.Add(this.IsCircle);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 320);
            this.panel1.TabIndex = 8;
            // 
            // mainColorButton
            // 
            this.mainColorButton.Location = new System.Drawing.Point(12, 199);
            this.mainColorButton.Name = "mainColorButton";
            this.mainColorButton.Size = new System.Drawing.Size(28, 23);
            this.mainColorButton.TabIndex = 8;
            this.mainColorButton.UseVisualStyleBackColor = true;
            this.mainColorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(58, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Основной цвет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(58, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Цвет заливки";
            // 
            // brushColorButton
            // 
            this.brushColorButton.Location = new System.Drawing.Point(12, 228);
            this.brushColorButton.Name = "brushColorButton";
            this.brushColorButton.Size = new System.Drawing.Size(28, 23);
            this.brushColorButton.TabIndex = 10;
            this.brushColorButton.UseVisualStyleBackColor = true;
            this.brushColorButton.Click += new System.EventHandler(this.brushColorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PositionLabel);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move_Mouse);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Timer TimerDraw;
        private System.Windows.Forms.RadioButton IsLine;
        private System.Windows.Forms.RadioButton IsRectangle;
        private System.Windows.Forms.RadioButton IsPoint;
        private System.Windows.Forms.RadioButton IsCircle;
        private System.Windows.Forms.RadioButton IsTriangle;
        private System.Windows.Forms.CheckBox IsFill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button mainColorButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button brushColorButton;
    }
}

