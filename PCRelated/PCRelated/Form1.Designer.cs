namespace PCRelated
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
            this.PropertyDataGrid = new System.Windows.Forms.PropertyGrid();
            this.RelatedBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PropertyDataGrid
            // 
            this.PropertyDataGrid.HelpVisible = false;
            this.PropertyDataGrid.Location = new System.Drawing.Point(967, 12);
            this.PropertyDataGrid.Name = "PropertyDataGrid";
            this.PropertyDataGrid.Size = new System.Drawing.Size(205, 607);
            this.PropertyDataGrid.TabIndex = 0;
            // 
            // RelatedBox
            // 
            this.RelatedBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RelatedBox.FormattingEnabled = true;
            this.RelatedBox.Items.AddRange(new object[] {
            "Клавиатура",
            "Мышь",
            "Принтер",
            "МФУ",
            "Монитор",
            "Комплект (мышь + клавиатура)"});
            this.RelatedBox.Location = new System.Drawing.Point(12, 52);
            this.RelatedBox.Name = "RelatedBox";
            this.RelatedBox.Size = new System.Drawing.Size(121, 21);
            this.RelatedBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 631);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RelatedBox);
            this.Controls.Add(this.PropertyDataGrid);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "PC Related";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PropertyGrid PropertyDataGrid;
        private System.Windows.Forms.ComboBox RelatedBox;
        private System.Windows.Forms.Label label1;
    }
}

