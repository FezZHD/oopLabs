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
            this.RelatedLabel = new System.Windows.Forms.Label();
            this.SerialazableBox = new System.Windows.Forms.ComboBox();
            this.SerialazableLabel = new System.Windows.Forms.Label();
            this.SerialazebleButton = new System.Windows.Forms.Button();
            this.DeserialazebleButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ListSwitcher = new System.Windows.Forms.NumericUpDown();
            this.CryptographyEnabled = new System.Windows.Forms.CheckBox();
            this.DllItems = new System.Windows.Forms.ComboBox();
            this.DecryptButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListSwitcher)).BeginInit();
            this.SuspendLayout();
            // 
            // PropertyDataGrid
            // 
            this.PropertyDataGrid.HelpVisible = false;
            this.PropertyDataGrid.Location = new System.Drawing.Point(931, 12);
            this.PropertyDataGrid.Name = "PropertyDataGrid";
            this.PropertyDataGrid.Size = new System.Drawing.Size(241, 607);
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
            this.RelatedBox.SelectedIndexChanged += new System.EventHandler(this.RelatedBox_SelectedIndexChanged);
            // 
            // RelatedLabel
            // 
            this.RelatedLabel.AutoSize = true;
            this.RelatedLabel.Location = new System.Drawing.Point(11, 36);
            this.RelatedLabel.Name = "RelatedLabel";
            this.RelatedLabel.Size = new System.Drawing.Size(85, 13);
            this.RelatedLabel.TabIndex = 2;
            this.RelatedLabel.Text = "Тип переферии";
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
            this.SerialazableBox.SelectedIndexChanged += new System.EventHandler(this.SerialazableBox_SelectedIndexChanged);
            // 
            // SerialazableLabel
            // 
            this.SerialazableLabel.AutoSize = true;
            this.SerialazableLabel.Location = new System.Drawing.Point(12, 83);
            this.SerialazableLabel.Name = "SerialazableLabel";
            this.SerialazableLabel.Size = new System.Drawing.Size(80, 13);
            this.SerialazableLabel.TabIndex = 4;
            this.SerialazableLabel.Text = "Сериализация";
            // 
            // SerialazebleButton
            // 
            this.SerialazebleButton.Enabled = false;
            this.SerialazebleButton.Location = new System.Drawing.Point(12, 522);
            this.SerialazebleButton.Name = "SerialazebleButton";
            this.SerialazebleButton.Size = new System.Drawing.Size(121, 33);
            this.SerialazebleButton.TabIndex = 5;
            this.SerialazebleButton.Text = "Сериализовать";
            this.SerialazebleButton.UseVisualStyleBackColor = true;
            this.SerialazebleButton.Click += new System.EventHandler(this.SerialazebleButton_Click);
            // 
            // DeserialazebleButton
            // 
            this.DeserialazebleButton.Enabled = false;
            this.DeserialazebleButton.Location = new System.Drawing.Point(15, 586);
            this.DeserialazebleButton.Name = "DeserialazebleButton";
            this.DeserialazebleButton.Size = new System.Drawing.Size(121, 33);
            this.DeserialazebleButton.TabIndex = 6;
            this.DeserialazebleButton.Text = "Десериализовать";
            this.DeserialazebleButton.UseVisualStyleBackColor = true;
            this.DeserialazebleButton.Click += new System.EventHandler(this.DeserialazebleButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(164, 586);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(121, 33);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Enabled = false;
            this.AddButton.Location = new System.Drawing.Point(164, 522);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(121, 33);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ListSwitcher
            // 
            this.ListSwitcher.Enabled = false;
            this.ListSwitcher.Location = new System.Drawing.Point(805, 599);
            this.ListSwitcher.Name = "ListSwitcher";
            this.ListSwitcher.Size = new System.Drawing.Size(120, 20);
            this.ListSwitcher.TabIndex = 9;
            this.ListSwitcher.ValueChanged += new System.EventHandler(this.ListSwitcher_ValueChanged);
            // 
            // CryptographyEnabled
            // 
            this.CryptographyEnabled.AutoSize = true;
            this.CryptographyEnabled.Location = new System.Drawing.Point(12, 499);
            this.CryptographyEnabled.Name = "CryptographyEnabled";
            this.CryptographyEnabled.Size = new System.Drawing.Size(91, 17);
            this.CryptographyEnabled.TabIndex = 10;
            this.CryptographyEnabled.Text = "Шифрование";
            this.CryptographyEnabled.UseVisualStyleBackColor = true;
            this.CryptographyEnabled.CheckedChanged += new System.EventHandler(this.CryptographyEnabled_CheckedChanged);
            // 
            // DllItems
            // 
            this.DllItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DllItems.Enabled = false;
            this.DllItems.FormattingEnabled = true;
            this.DllItems.Location = new System.Drawing.Point(164, 499);
            this.DllItems.Name = "DllItems";
            this.DllItems.Size = new System.Drawing.Size(121, 21);
            this.DllItems.TabIndex = 11;
            // 
            // DecryptButton
            // 
            this.DecryptButton.Enabled = false;
            this.DecryptButton.Location = new System.Drawing.Point(306, 586);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(127, 34);
            this.DecryptButton.TabIndex = 12;
            this.DecryptButton.Text = "Дешифровать";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 632);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.DllItems);
            this.Controls.Add(this.CryptographyEnabled);
            this.Controls.Add(this.ListSwitcher);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DeserialazebleButton);
            this.Controls.Add(this.SerialazebleButton);
            this.Controls.Add(this.SerialazableLabel);
            this.Controls.Add(this.SerialazableBox);
            this.Controls.Add(this.RelatedLabel);
            this.Controls.Add(this.RelatedBox);
            this.Controls.Add(this.PropertyDataGrid);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 670);
            this.MinimumSize = new System.Drawing.Size(1200, 670);
            this.Name = "MainForm";
            this.Text = "PC Related";
            ((System.ComponentModel.ISupportInitialize)(this.ListSwitcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PropertyGrid PropertyDataGrid;
        private System.Windows.Forms.ComboBox RelatedBox;
        private System.Windows.Forms.Label RelatedLabel;
        private System.Windows.Forms.ComboBox SerialazableBox;
        private System.Windows.Forms.Label SerialazableLabel;
        private System.Windows.Forms.Button SerialazebleButton;
        private System.Windows.Forms.Button DeserialazebleButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.NumericUpDown ListSwitcher;
        private System.Windows.Forms.CheckBox CryptographyEnabled;
        private System.Windows.Forms.ComboBox DllItems;
        private System.Windows.Forms.Button DecryptButton;
    }
}

