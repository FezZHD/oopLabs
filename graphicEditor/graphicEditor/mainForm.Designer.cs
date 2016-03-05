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
            this.textList = new System.Windows.Forms.TextBox();
            this.lineButton = new System.Windows.Forms.Button();
            this.firstCoordinate = new System.Windows.Forms.TextBox();
            this.First = new System.Windows.Forms.GroupBox();
            this.Second = new System.Windows.Forms.GroupBox();
            this.secondCoordinate = new System.Windows.Forms.TextBox();
            this.Third = new System.Windows.Forms.GroupBox();
            this.thirdCoordinate = new System.Windows.Forms.TextBox();
            this.Fouth = new System.Windows.Forms.GroupBox();
            this.fouthCoordinate = new System.Windows.Forms.TextBox();
            this.Fifth = new System.Windows.Forms.GroupBox();
            this.fifthCoordinate = new System.Windows.Forms.TextBox();
            this.Triangle = new System.Windows.Forms.Button();
            this.Rectangle = new System.Windows.Forms.Button();
            this.Circle = new System.Windows.Forms.Button();
            this.Ellipse = new System.Windows.Forms.Button();
            this.Pentagon = new System.Windows.Forms.Button();
            this.DrawAll = new System.Windows.Forms.Button();
            this.First.SuspendLayout();
            this.Second.SuspendLayout();
            this.Third.SuspendLayout();
            this.Fouth.SuspendLayout();
            this.Fifth.SuspendLayout();
            this.SuspendLayout();
            // 
            // textList
            // 
            this.textList.Location = new System.Drawing.Point(0, 12);
            this.textList.Multiline = true;
            this.textList.Name = "textList";
            this.textList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textList.Size = new System.Drawing.Size(216, 586);
            this.textList.TabIndex = 0;
            // 
            // lineButton
            // 
            this.lineButton.Location = new System.Drawing.Point(251, 12);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(89, 27);
            this.lineButton.TabIndex = 1;
            this.lineButton.Text = "Line";
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.LineButtonClick);
            // 
            // firstCoordinate
            // 
            this.firstCoordinate.Location = new System.Drawing.Point(6, 19);
            this.firstCoordinate.Name = "firstCoordinate";
            this.firstCoordinate.Size = new System.Drawing.Size(100, 20);
            this.firstCoordinate.TabIndex = 2;
            // 
            // First
            // 
            this.First.Controls.Add(this.firstCoordinate);
            this.First.Location = new System.Drawing.Point(389, 12);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(131, 56);
            this.First.TabIndex = 4;
            this.First.TabStop = false;
            this.First.Text = "The First Cordinate";
            // 
            // Second
            // 
            this.Second.Controls.Add(this.secondCoordinate);
            this.Second.Location = new System.Drawing.Point(389, 93);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(131, 56);
            this.Second.TabIndex = 5;
            this.Second.TabStop = false;
            this.Second.Text = "The Second Cordinate";
            // 
            // secondCoordinate
            // 
            this.secondCoordinate.Location = new System.Drawing.Point(6, 19);
            this.secondCoordinate.Name = "secondCoordinate";
            this.secondCoordinate.Size = new System.Drawing.Size(100, 20);
            this.secondCoordinate.TabIndex = 2;
            // 
            // Third
            // 
            this.Third.Controls.Add(this.thirdCoordinate);
            this.Third.Location = new System.Drawing.Point(389, 171);
            this.Third.Name = "Third";
            this.Third.Size = new System.Drawing.Size(131, 56);
            this.Third.TabIndex = 5;
            this.Third.TabStop = false;
            this.Third.Text = "The Third Cordinate";
            // 
            // thirdCoordinate
            // 
            this.thirdCoordinate.Location = new System.Drawing.Point(6, 19);
            this.thirdCoordinate.Name = "thirdCoordinate";
            this.thirdCoordinate.Size = new System.Drawing.Size(100, 20);
            this.thirdCoordinate.TabIndex = 2;
            // 
            // Fouth
            // 
            this.Fouth.Controls.Add(this.fouthCoordinate);
            this.Fouth.Location = new System.Drawing.Point(389, 243);
            this.Fouth.Name = "Fouth";
            this.Fouth.Size = new System.Drawing.Size(131, 56);
            this.Fouth.TabIndex = 5;
            this.Fouth.TabStop = false;
            this.Fouth.Text = "The Fourth Cordinate";
            // 
            // fouthCoordinate
            // 
            this.fouthCoordinate.Location = new System.Drawing.Point(6, 19);
            this.fouthCoordinate.Name = "fouthCoordinate";
            this.fouthCoordinate.Size = new System.Drawing.Size(100, 20);
            this.fouthCoordinate.TabIndex = 2;
            // 
            // Fifth
            // 
            this.Fifth.Controls.Add(this.fifthCoordinate);
            this.Fifth.Location = new System.Drawing.Point(389, 323);
            this.Fifth.Name = "Fifth";
            this.Fifth.Size = new System.Drawing.Size(131, 56);
            this.Fifth.TabIndex = 5;
            this.Fifth.TabStop = false;
            this.Fifth.Text = "The Fifth Cordinate";
            // 
            // fifthCoordinate
            // 
            this.fifthCoordinate.Location = new System.Drawing.Point(5, 19);
            this.fifthCoordinate.Name = "fifthCoordinate";
            this.fifthCoordinate.Size = new System.Drawing.Size(100, 20);
            this.fifthCoordinate.TabIndex = 2;
            // 
            // Triangle
            // 
            this.Triangle.Location = new System.Drawing.Point(251, 54);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(89, 27);
            this.Triangle.TabIndex = 6;
            this.Triangle.Text = "Triangle";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.Location = new System.Drawing.Point(251, 93);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(89, 27);
            this.Rectangle.TabIndex = 7;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Circle
            // 
            this.Circle.Location = new System.Drawing.Point(251, 126);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(89, 30);
            this.Circle.TabIndex = 8;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.CircleClick);
            // 
            // Ellipse
            // 
            this.Ellipse.Location = new System.Drawing.Point(251, 162);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(89, 30);
            this.Ellipse.TabIndex = 9;
            this.Ellipse.Text = "Ellipse";
            this.Ellipse.UseVisualStyleBackColor = true;
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // Pentagon
            // 
            this.Pentagon.Location = new System.Drawing.Point(251, 198);
            this.Pentagon.Name = "Pentagon";
            this.Pentagon.Size = new System.Drawing.Size(89, 29);
            this.Pentagon.TabIndex = 10;
            this.Pentagon.Text = "Pentagon";
            this.Pentagon.UseVisualStyleBackColor = true;
            this.Pentagon.Click += new System.EventHandler(this.Pentagon_Click);
            // 
            // DrawAll
            // 
            this.DrawAll.Location = new System.Drawing.Point(251, 243);
            this.DrawAll.Name = "DrawAll";
            this.DrawAll.Size = new System.Drawing.Size(89, 29);
            this.DrawAll.TabIndex = 11;
            this.DrawAll.Text = "Draw All";
            this.DrawAll.UseVisualStyleBackColor = true;
            this.DrawAll.Click += new System.EventHandler(this.DrawAll_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(553, 610);
            this.Controls.Add(this.DrawAll);
            this.Controls.Add(this.Pentagon);
            this.Controls.Add(this.Ellipse);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.Triangle);
            this.Controls.Add(this.Second);
            this.Controls.Add(this.Third);
            this.Controls.Add(this.Fouth);
            this.Controls.Add(this.Fifth);
            this.Controls.Add(this.First);
            this.Controls.Add(this.lineButton);
            this.Controls.Add(this.textList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Graphic Editror";
            this.First.ResumeLayout(false);
            this.First.PerformLayout();
            this.Second.ResumeLayout(false);
            this.Second.PerformLayout();
            this.Third.ResumeLayout(false);
            this.Third.PerformLayout();
            this.Fouth.ResumeLayout(false);
            this.Fouth.PerformLayout();
            this.Fifth.ResumeLayout(false);
            this.Fifth.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textList;
        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.TextBox firstCoordinate;
        private System.Windows.Forms.GroupBox First;
        private System.Windows.Forms.GroupBox Second;
        private System.Windows.Forms.TextBox secondCoordinate;
        private System.Windows.Forms.GroupBox Third;
        private System.Windows.Forms.TextBox thirdCoordinate;
        private System.Windows.Forms.GroupBox Fouth;
        private System.Windows.Forms.TextBox fouthCoordinate;
        private System.Windows.Forms.GroupBox Fifth;
        private System.Windows.Forms.TextBox fifthCoordinate;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button Ellipse;
        private System.Windows.Forms.Button Pentagon;
        private System.Windows.Forms.Button DrawAll;
    }
}

