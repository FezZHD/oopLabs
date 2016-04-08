namespace graphicEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lineButton = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.Rectangle = new System.Windows.Forms.Button();
            this.Circle = new System.Windows.Forms.Button();
            this.Ellipse = new System.Windows.Forms.Button();
            this.Pentagon = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SelectColor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ThiknessValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThiknessValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lineButton
            // 
            this.lineButton.Location = new System.Drawing.Point(771, 12);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(89, 27);
            this.lineButton.TabIndex = 1;
            this.lineButton.Tag = "0";
            this.lineButton.Text = "Line";
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Triangle
            // 
            this.Triangle.Location = new System.Drawing.Point(771, 54);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(89, 27);
            this.Triangle.TabIndex = 6;
            this.Triangle.Tag = "1";
            this.Triangle.Text = "Triangle";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Rectangle
            // 
            this.Rectangle.Location = new System.Drawing.Point(771, 93);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(89, 27);
            this.Rectangle.TabIndex = 7;
            this.Rectangle.Tag = "2";
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Circle
            // 
            this.Circle.Location = new System.Drawing.Point(771, 126);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(89, 30);
            this.Circle.TabIndex = 8;
            this.Circle.Tag = "3";
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Ellipse
            // 
            this.Ellipse.Location = new System.Drawing.Point(771, 162);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(89, 30);
            this.Ellipse.TabIndex = 9;
            this.Ellipse.Tag = "4";
            this.Ellipse.Text = "Ellipse";
            this.Ellipse.UseVisualStyleBackColor = true;
            this.Ellipse.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Pentagon
            // 
            this.Pentagon.Location = new System.Drawing.Point(771, 198);
            this.Pentagon.Name = "Pentagon";
            this.Pentagon.Size = new System.Drawing.Size(89, 29);
            this.Pentagon.TabIndex = 10;
            this.Pentagon.Tag = "5";
            this.Pentagon.Text = "Pentagon";
            this.Pentagon.UseVisualStyleBackColor = true;
            this.Pentagon.Click += new System.EventHandler(this.ButtonClick);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.canvas.Location = new System.Drawing.Point(1, 1);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(754, 611);
            this.canvas.TabIndex = 12;
            this.canvas.TabStop = false;
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(771, 575);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 13;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearClick);
            // 
            // SelectColor
            // 
            this.SelectColor.Location = new System.Drawing.Point(771, 500);
            this.SelectColor.Name = "SelectColor";
            this.SelectColor.Size = new System.Drawing.Size(75, 23);
            this.SelectColor.TabIndex = 14;
            this.SelectColor.Text = "Color";
            this.SelectColor.UseVisualStyleBackColor = true;
            this.SelectColor.Click += new System.EventHandler(this.SelectColor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ThiknessValue);
            this.groupBox1.Location = new System.Drawing.Point(771, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 53);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thikness";
            // 
            // ThiknessValue
            // 
            this.ThiknessValue.Location = new System.Drawing.Point(6, 19);
            this.ThiknessValue.Name = "ThiknessValue";
            this.ThiknessValue.Size = new System.Drawing.Size(77, 20);
            this.ThiknessValue.TabIndex = 0;
            this.ThiknessValue.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(872, 610);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SelectColor);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.Pentagon);
            this.Controls.Add(this.Ellipse);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.Triangle);
            this.Controls.Add(this.lineButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Graphic Editror";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ThiknessValue)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button Ellipse;
        private System.Windows.Forms.Button Pentagon;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SelectColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown ThiknessValue;
    }
}

