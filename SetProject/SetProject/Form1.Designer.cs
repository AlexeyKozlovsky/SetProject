namespace SetProject
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
            this.uniSetTextBox = new System.Windows.Forms.TextBox();
            this.initUniSetButton = new System.Windows.Forms.Button();
            this.currentSetTextBox = new System.Windows.Forms.TextBox();
            this.addSetButton = new System.Windows.Forms.Button();
            this.setsListBox = new System.Windows.Forms.ListBox();
            this.firstBinarySetComboBox = new System.Windows.Forms.ComboBox();
            this.secondBinaryComboBox = new System.Windows.Forms.ComboBox();
            this.binaryOperationComboBox = new System.Windows.Forms.ComboBox();
            this.unarySetComboBox = new System.Windows.Forms.ComboBox();
            this.unaryOperationComboBox = new System.Windows.Forms.ComboBox();
            this.doBinatyButton = new System.Windows.Forms.Button();
            this.doUnaryButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.uniSetLabel = new System.Windows.Forms.Label();
            this.currentSetLabel = new System.Windows.Forms.Label();
            this.binaryOperationsLabel = new System.Windows.Forms.Label();
            this.unaryOperationsLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uniSetTextBox
            // 
            this.uniSetTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uniSetTextBox.Location = new System.Drawing.Point(41, 77);
            this.uniSetTextBox.Name = "uniSetTextBox";
            this.uniSetTextBox.Size = new System.Drawing.Size(378, 29);
            this.uniSetTextBox.TabIndex = 0;
            this.uniSetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // initUniSetButton
            // 
            this.initUniSetButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.initUniSetButton.Location = new System.Drawing.Point(452, 77);
            this.initUniSetButton.Name = "initUniSetButton";
            this.initUniSetButton.Size = new System.Drawing.Size(109, 29);
            this.initUniSetButton.TabIndex = 1;
            this.initUniSetButton.Text = "Задать";
            this.initUniSetButton.UseVisualStyleBackColor = true;
            this.initUniSetButton.Click += new System.EventHandler(this.initUniSetButton_Click);
            // 
            // currentSetTextBox
            // 
            this.currentSetTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentSetTextBox.Location = new System.Drawing.Point(41, 149);
            this.currentSetTextBox.Name = "currentSetTextBox";
            this.currentSetTextBox.Size = new System.Drawing.Size(378, 29);
            this.currentSetTextBox.TabIndex = 2;
            this.currentSetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addSetButton
            // 
            this.addSetButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addSetButton.Location = new System.Drawing.Point(452, 149);
            this.addSetButton.Name = "addSetButton";
            this.addSetButton.Size = new System.Drawing.Size(109, 29);
            this.addSetButton.TabIndex = 3;
            this.addSetButton.Text = "Добавить";
            this.addSetButton.UseVisualStyleBackColor = true;
            this.addSetButton.Click += new System.EventHandler(this.addSetButton_Click);
            // 
            // setsListBox
            // 
            this.setsListBox.FormattingEnabled = true;
            this.setsListBox.ItemHeight = 16;
            this.setsListBox.Location = new System.Drawing.Point(41, 201);
            this.setsListBox.Name = "setsListBox";
            this.setsListBox.Size = new System.Drawing.Size(378, 276);
            this.setsListBox.TabIndex = 4;
            // 
            // firstBinarySetComboBox
            // 
            this.firstBinarySetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.firstBinarySetComboBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstBinarySetComboBox.FormattingEnabled = true;
            this.firstBinarySetComboBox.Location = new System.Drawing.Point(425, 225);
            this.firstBinarySetComboBox.Name = "firstBinarySetComboBox";
            this.firstBinarySetComboBox.Size = new System.Drawing.Size(86, 31);
            this.firstBinarySetComboBox.TabIndex = 5;
            // 
            // secondBinaryComboBox
            // 
            this.secondBinaryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.secondBinaryComboBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondBinaryComboBox.FormattingEnabled = true;
            this.secondBinaryComboBox.Location = new System.Drawing.Point(517, 225);
            this.secondBinaryComboBox.Name = "secondBinaryComboBox";
            this.secondBinaryComboBox.Size = new System.Drawing.Size(86, 31);
            this.secondBinaryComboBox.TabIndex = 6;
            // 
            // binaryOperationComboBox
            // 
            this.binaryOperationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.binaryOperationComboBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.binaryOperationComboBox.FormattingEnabled = true;
            this.binaryOperationComboBox.Items.AddRange(new object[] {
            "Объединение",
            "Пересечение"});
            this.binaryOperationComboBox.Location = new System.Drawing.Point(475, 260);
            this.binaryOperationComboBox.Name = "binaryOperationComboBox";
            this.binaryOperationComboBox.Size = new System.Drawing.Size(86, 31);
            this.binaryOperationComboBox.TabIndex = 7;
            // 
            // unarySetComboBox
            // 
            this.unarySetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unarySetComboBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unarySetComboBox.FormattingEnabled = true;
            this.unarySetComboBox.Location = new System.Drawing.Point(475, 324);
            this.unarySetComboBox.Name = "unarySetComboBox";
            this.unarySetComboBox.Size = new System.Drawing.Size(86, 31);
            this.unarySetComboBox.TabIndex = 8;
            // 
            // unaryOperationComboBox
            // 
            this.unaryOperationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unaryOperationComboBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unaryOperationComboBox.FormattingEnabled = true;
            this.unaryOperationComboBox.Items.AddRange(new object[] {
            "Отрицание"});
            this.unaryOperationComboBox.Location = new System.Drawing.Point(475, 361);
            this.unaryOperationComboBox.Name = "unaryOperationComboBox";
            this.unaryOperationComboBox.Size = new System.Drawing.Size(86, 31);
            this.unaryOperationComboBox.TabIndex = 9;
            // 
            // doBinatyButton
            // 
            this.doBinatyButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doBinatyButton.Location = new System.Drawing.Point(567, 260);
            this.doBinatyButton.Name = "doBinatyButton";
            this.doBinatyButton.Size = new System.Drawing.Size(123, 29);
            this.doBinatyButton.TabIndex = 10;
            this.doBinatyButton.Text = "Выполнить";
            this.doBinatyButton.UseVisualStyleBackColor = true;
            this.doBinatyButton.Click += new System.EventHandler(this.doBinatyButton_Click);
            // 
            // doUnaryButton
            // 
            this.doUnaryButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doUnaryButton.Location = new System.Drawing.Point(567, 361);
            this.doUnaryButton.Name = "doUnaryButton";
            this.doUnaryButton.Size = new System.Drawing.Size(123, 29);
            this.doUnaryButton.TabIndex = 11;
            this.doUnaryButton.Text = "Выполнить";
            this.doUnaryButton.UseVisualStyleBackColor = true;
            this.doUnaryButton.Click += new System.EventHandler(this.doUnaryButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(210, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(301, 27);
            this.titleLabel.TabIndex = 12;
            this.titleLabel.Text = "Операции над множествами";
            // 
            // uniSetLabel
            // 
            this.uniSetLabel.AutoSize = true;
            this.uniSetLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uniSetLabel.Location = new System.Drawing.Point(103, 51);
            this.uniSetLabel.Name = "uniSetLabel";
            this.uniSetLabel.Size = new System.Drawing.Size(245, 23);
            this.uniSetLabel.TabIndex = 13;
            this.uniSetLabel.Text = "Универсальное множество";
            // 
            // currentSetLabel
            // 
            this.currentSetLabel.AutoSize = true;
            this.currentSetLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentSetLabel.Location = new System.Drawing.Point(125, 123);
            this.currentSetLabel.Name = "currentSetLabel";
            this.currentSetLabel.Size = new System.Drawing.Size(185, 23);
            this.currentSetLabel.TabIndex = 14;
            this.currentSetLabel.Text = "Текущее множество";
            // 
            // binaryOperationsLabel
            // 
            this.binaryOperationsLabel.AutoSize = true;
            this.binaryOperationsLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.binaryOperationsLabel.Location = new System.Drawing.Point(421, 199);
            this.binaryOperationsLabel.Name = "binaryOperationsLabel";
            this.binaryOperationsLabel.Size = new System.Drawing.Size(187, 23);
            this.binaryOperationsLabel.TabIndex = 15;
            this.binaryOperationsLabel.Text = "Бинарные операции";
            // 
            // unaryOperationsLabel
            // 
            this.unaryOperationsLabel.AutoSize = true;
            this.unaryOperationsLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unaryOperationsLabel.Location = new System.Drawing.Point(425, 298);
            this.unaryOperationsLabel.Name = "unaryOperationsLabel";
            this.unaryOperationsLabel.Size = new System.Drawing.Size(176, 23);
            this.unaryOperationsLabel.TabIndex = 16;
            this.unaryOperationsLabel.Text = "Унарные операции";
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.Location = new System.Drawing.Point(438, 448);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(123, 29);
            this.updateButton.TabIndex = 17;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(567, 448);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(123, 29);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 489);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.unaryOperationsLabel);
            this.Controls.Add(this.binaryOperationsLabel);
            this.Controls.Add(this.currentSetLabel);
            this.Controls.Add(this.uniSetLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.doUnaryButton);
            this.Controls.Add(this.doBinatyButton);
            this.Controls.Add(this.unaryOperationComboBox);
            this.Controls.Add(this.unarySetComboBox);
            this.Controls.Add(this.binaryOperationComboBox);
            this.Controls.Add(this.secondBinaryComboBox);
            this.Controls.Add(this.firstBinarySetComboBox);
            this.Controls.Add(this.setsListBox);
            this.Controls.Add(this.addSetButton);
            this.Controls.Add(this.currentSetTextBox);
            this.Controls.Add(this.initUniSetButton);
            this.Controls.Add(this.uniSetTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uniSetTextBox;
        private System.Windows.Forms.Button initUniSetButton;
        private System.Windows.Forms.TextBox currentSetTextBox;
        private System.Windows.Forms.Button addSetButton;
        private System.Windows.Forms.ListBox setsListBox;
        private System.Windows.Forms.ComboBox firstBinarySetComboBox;
        private System.Windows.Forms.ComboBox secondBinaryComboBox;
        private System.Windows.Forms.ComboBox binaryOperationComboBox;
        private System.Windows.Forms.ComboBox unarySetComboBox;
        private System.Windows.Forms.ComboBox unaryOperationComboBox;
        private System.Windows.Forms.Button doBinatyButton;
        private System.Windows.Forms.Button doUnaryButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label uniSetLabel;
        private System.Windows.Forms.Label currentSetLabel;
        private System.Windows.Forms.Label binaryOperationsLabel;
        private System.Windows.Forms.Label unaryOperationsLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

