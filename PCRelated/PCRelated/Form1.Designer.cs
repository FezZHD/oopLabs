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
            this.SerialazableBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SerialazebleButton = new System.Windows.Forms.Button();
            this.DeserialazebleButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ItemsView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RelatedName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Manufacture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Тип переферии";
            // 
            // SerialazableBox
            // 
            this.SerialazableBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SerialazableBox.FormattingEnabled = true;
            this.SerialazableBox.Items.AddRange(new object[] {
            "XML",
            "Бинарная",
            "Текстовая\t"});
            this.SerialazableBox.Location = new System.Drawing.Point(12, 99);
            this.SerialazableBox.Name = "SerialazableBox";
            this.SerialazableBox.Size = new System.Drawing.Size(121, 21);
            this.SerialazableBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сериализация";
            // 
            // SerialazebleButton
            // 
            this.SerialazebleButton.Location = new System.Drawing.Point(12, 522);
            this.SerialazebleButton.Name = "SerialazebleButton";
            this.SerialazebleButton.Size = new System.Drawing.Size(121, 33);
            this.SerialazebleButton.TabIndex = 5;
            this.SerialazebleButton.Text = "Сериализовать";
            this.SerialazebleButton.UseVisualStyleBackColor = true;
            // 
            // DeserialazebleButton
            // 
            this.DeserialazebleButton.Location = new System.Drawing.Point(15, 586);
            this.DeserialazebleButton.Name = "DeserialazebleButton";
            this.DeserialazebleButton.Size = new System.Drawing.Size(121, 33);
            this.DeserialazebleButton.TabIndex = 6;
            this.DeserialazebleButton.Text = "Десериализовать";
            this.DeserialazebleButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(164, 586);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(121, 33);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(164, 522);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(121, 33);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // ItemsView
            // 
            this.ItemsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Manufacture,
            this.RelatedName,
            this.Type});
            this.ItemsView.Location = new System.Drawing.Point(582, 12);
            this.ItemsView.MultiSelect = false;
            this.ItemsView.Name = "ItemsView";
            this.ItemsView.Size = new System.Drawing.Size(346, 607);
            this.ItemsView.TabIndex = 9;
            this.ItemsView.UseCompatibleStateImageBehavior = false;
            this.ItemsView.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.DisplayIndex = 0;
            this.ID.Text = "ID";
            this.ID.Width = 30;
            // 
            // Type
            // 
            this.Type.DisplayIndex = 0;
            this.Type.Text = "Тип переферии";
            // 
            // RelatedName
            // 
            this.RelatedName.Text = "Имя";
            this.RelatedName.Width = 90;
            // 
            // Manufacture
            // 
            this.Manufacture.Text = "Производитель";
            this.Manufacture.Width = 131;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 631);
            this.Controls.Add(this.ItemsView);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DeserialazebleButton);
            this.Controls.Add(this.SerialazebleButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SerialazableBox);
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
        private System.Windows.Forms.ComboBox SerialazableBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SerialazebleButton;
        private System.Windows.Forms.Button DeserialazebleButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListView ItemsView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader RelatedName;
        private System.Windows.Forms.ColumnHeader Manufacture;
    }
}

