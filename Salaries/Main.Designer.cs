namespace Salaries
{
    partial class Main
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
            this.EditButton = new System.Windows.Forms.Button();
            this.CheckBoxSunday = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameSename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.work = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SettingButton = new System.Windows.Forms.Button();
            this.TextBoxAmount = new System.Windows.Forms.TextBox();
            this.ComboBoxWork = new System.Windows.Forms.ComboBox();
            this.WControlButton = new System.Windows.Forms.Button();
            this.WMControlButton = new System.Windows.Forms.Button();
            this.ComboBoxName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(575, 10);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(27, 27);
            this.EditButton.TabIndex = 21;
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // CheckBoxSunday
            // 
            this.CheckBoxSunday.AutoSize = true;
            this.CheckBoxSunday.Location = new System.Drawing.Point(489, 16);
            this.CheckBoxSunday.MinimumSize = new System.Drawing.Size(67, 17);
            this.CheckBoxSunday.Name = "CheckBoxSunday";
            this.CheckBoxSunday.Size = new System.Drawing.Size(67, 17);
            this.CheckBoxSunday.TabIndex = 20;
            this.CheckBoxSunday.Text = "Суббота";
            this.CheckBoxSunday.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameSename,
            this.work,
            this.price,
            this.calc,
            this.endPrice,
            this.subota});
            this.dataGridView1.Location = new System.Drawing.Point(-2, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(687, 839);
            this.dataGridView1.TabIndex = 19;
            // 
            // NameSename
            // 
            this.NameSename.HeaderText = "Имя Фамилия";
            this.NameSename.Name = "NameSename";
            this.NameSename.ReadOnly = true;
            // 
            // work
            // 
            this.work.HeaderText = "Вид работ";
            this.work.Name = "work";
            this.work.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Цена за 1шт.";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // calc
            // 
            this.calc.HeaderText = "Кол.";
            this.calc.Name = "calc";
            this.calc.ReadOnly = true;
            // 
            // endPrice
            // 
            this.endPrice.HeaderText = "Итог";
            this.endPrice.Name = "endPrice";
            this.endPrice.ReadOnly = true;
            // 
            // subota
            // 
            this.subota.HeaderText = "Суб.";
            this.subota.Name = "subota";
            this.subota.ReadOnly = true;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConfirmButton.Location = new System.Drawing.Point(608, 40);
            this.ConfirmButton.MinimumSize = new System.Drawing.Size(27, 27);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(60, 27);
            this.ConfirmButton.TabIndex = 18;
            this.ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(641, 10);
            this.SaveButton.MinimumSize = new System.Drawing.Size(27, 27);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(27, 27);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // SettingButton
            // 
            this.SettingButton.Location = new System.Drawing.Point(608, 10);
            this.SettingButton.MinimumSize = new System.Drawing.Size(27, 27);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(27, 27);
            this.SettingButton.TabIndex = 16;
            this.SettingButton.Text = " ";
            this.SettingButton.UseVisualStyleBackColor = true;
            // 
            // TextBoxAmount
            // 
            this.TextBoxAmount.Location = new System.Drawing.Point(489, 44);
            this.TextBoxAmount.MinimumSize = new System.Drawing.Size(113, 20);
            this.TextBoxAmount.Name = "TextBoxAmount";
            this.TextBoxAmount.Size = new System.Drawing.Size(113, 20);
            this.TextBoxAmount.TabIndex = 15;
            this.TextBoxAmount.Text = "Количество";
            // 
            // ComboBoxWork
            // 
            this.ComboBoxWork.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxWork.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxWork.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboBoxWork.FormattingEnabled = true;
            this.ComboBoxWork.Location = new System.Drawing.Point(242, 44);
            this.ComboBoxWork.MinimumSize = new System.Drawing.Size(225, 0);
            this.ComboBoxWork.Name = "ComboBoxWork";
            this.ComboBoxWork.Size = new System.Drawing.Size(225, 21);
            this.ComboBoxWork.TabIndex = 14;
            // 
            // WControlButton
            // 
            this.WControlButton.AutoSize = true;
            this.WControlButton.Location = new System.Drawing.Point(242, 9);
            this.WControlButton.MinimumSize = new System.Drawing.Size(225, 29);
            this.WControlButton.Name = "WControlButton";
            this.WControlButton.Size = new System.Drawing.Size(225, 29);
            this.WControlButton.TabIndex = 13;
            this.WControlButton.Text = "Управление работами";
            this.WControlButton.UseVisualStyleBackColor = true;
            this.WControlButton.Click += new System.EventHandler(this.WControlButton_Click);
            // 
            // WMControlButton
            // 
            this.WMControlButton.Location = new System.Drawing.Point(11, 9);
            this.WMControlButton.MinimumSize = new System.Drawing.Size(225, 29);
            this.WMControlButton.Name = "WMControlButton";
            this.WMControlButton.Size = new System.Drawing.Size(225, 29);
            this.WMControlButton.TabIndex = 12;
            this.WMControlButton.Text = "Управление рабочими";
            this.WMControlButton.UseVisualStyleBackColor = true;
            this.WMControlButton.Click += new System.EventHandler(this.WMControlButton_Click);
            // 
            // ComboBoxName
            // 
            this.ComboBoxName.AccessibleDescription = "";
            this.ComboBoxName.AccessibleName = "";
            this.ComboBoxName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxName.FormattingEnabled = true;
            this.ComboBoxName.Location = new System.Drawing.Point(11, 44);
            this.ComboBoxName.MinimumSize = new System.Drawing.Size(225, 0);
            this.ComboBoxName.Name = "ComboBoxName";
            this.ComboBoxName.Size = new System.Drawing.Size(225, 21);
            this.ComboBoxName.Sorted = true;
            this.ComboBoxName.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 698);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.CheckBoxSunday);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SettingButton);
            this.Controls.Add(this.TextBoxAmount);
            this.Controls.Add(this.ComboBoxWork);
            this.Controls.Add(this.WControlButton);
            this.Controls.Add(this.WMControlButton);
            this.Controls.Add(this.ComboBoxName);
            this.MinimumSize = new System.Drawing.Size(697, 737);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.CheckBox CheckBoxSunday;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSename;
        private System.Windows.Forms.DataGridViewTextBoxColumn work;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn calc;
        private System.Windows.Forms.DataGridViewTextBoxColumn endPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn subota;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.TextBox TextBoxAmount;
        private System.Windows.Forms.ComboBox ComboBoxWork;
        private System.Windows.Forms.Button WControlButton;
        private System.Windows.Forms.Button WMControlButton;
        private System.Windows.Forms.ComboBox ComboBoxName;
    }
}

