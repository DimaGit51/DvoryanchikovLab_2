namespace LaboratoryNumber_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.informationME = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.informationFORMULA = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_Calculate = new System.Windows.Forms.Button();
            this.textBox_answer = new System.Windows.Forms.TextBox();
            this.label_info_n = new System.Windows.Forms.Label();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.exit_button = new System.Windows.Forms.Button();
            this.textBox_ErrorCode = new System.Windows.Forms.TextBox();
            this.textBox_Errors = new System.Windows.Forms.TextBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.informationME);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.informationFORMULA);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 387);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "О программе";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // informationME
            // 
            this.informationME.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.informationME.Location = new System.Drawing.Point(471, 7);
            this.informationME.Multiline = true;
            this.informationME.Name = "informationME";
            this.informationME.ReadOnly = true;
            this.informationME.Size = new System.Drawing.Size(291, 213);
            this.informationME.TabIndex = 2;
            this.informationME.Text = "Разработчик: Дворянчиков Дмитрий Иванович 6101-090301";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 122);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // informationFORMULA
            // 
            this.informationFORMULA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.informationFORMULA.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.informationFORMULA.Location = new System.Drawing.Point(6, 6);
            this.informationFORMULA.Multiline = true;
            this.informationFORMULA.Name = "informationFORMULA";
            this.informationFORMULA.ReadOnly = true;
            this.informationFORMULA.Size = new System.Drawing.Size(458, 86);
            this.informationFORMULA.TabIndex = 0;
            this.informationFORMULA.Text = "23. Реализуйте рекурсивный алгоритм вычисления значения суммы для заданного целог" +
    "о n";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_Clear);
            this.tabPage2.Controls.Add(this.textBox_Errors);
            this.tabPage2.Controls.Add(this.textBox_ErrorCode);
            this.tabPage2.Controls.Add(this.button_Calculate);
            this.tabPage2.Controls.Add(this.textBox_answer);
            this.tabPage2.Controls.Add(this.label_info_n);
            this.tabPage2.Controls.Add(this.textBox_n);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задание";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_Calculate
            // 
            this.button_Calculate.Image = ((System.Drawing.Image)(resources.GetObject("button_Calculate.Image")));
            this.button_Calculate.Location = new System.Drawing.Point(409, 77);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(343, 164);
            this.button_Calculate.TabIndex = 5;
            this.button_Calculate.UseVisualStyleBackColor = true;
            this.button_Calculate.Click += new System.EventHandler(this.button_Calculate_Click);
            // 
            // textBox_answer
            // 
            this.textBox_answer.Location = new System.Drawing.Point(409, 260);
            this.textBox_answer.Name = "textBox_answer";
            this.textBox_answer.ReadOnly = true;
            this.textBox_answer.Size = new System.Drawing.Size(343, 34);
            this.textBox_answer.TabIndex = 2;
            // 
            // label_info_n
            // 
            this.label_info_n.AutoSize = true;
            this.label_info_n.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label_info_n.Location = new System.Drawing.Point(22, 28);
            this.label_info_n.Name = "label_info_n";
            this.label_info_n.Size = new System.Drawing.Size(355, 27);
            this.label_info_n.TabIndex = 1;
            this.label_info_n.Text = "Введите целое число n [от 1 до 5]";
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(409, 28);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(343, 34);
            this.textBox_n.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.exit_button);
            this.tabPage3.Location = new System.Drawing.Point(4, 35);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 387);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Выход";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // exit_button
            // 
            this.exit_button.Image = ((System.Drawing.Image)(resources.GetObject("exit_button.Image")));
            this.exit_button.Location = new System.Drawing.Point(159, 124);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(449, 135);
            this.exit_button.TabIndex = 0;
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // textBox_ErrorCode
            // 
            this.textBox_ErrorCode.Location = new System.Drawing.Point(27, 77);
            this.textBox_ErrorCode.Name = "textBox_ErrorCode";
            this.textBox_ErrorCode.ReadOnly = true;
            this.textBox_ErrorCode.Size = new System.Drawing.Size(350, 34);
            this.textBox_ErrorCode.TabIndex = 6;
            this.textBox_ErrorCode.Text = "Errors Code:";
            // 
            // textBox_Errors
            // 
            this.textBox_Errors.Location = new System.Drawing.Point(27, 134);
            this.textBox_Errors.Multiline = true;
            this.textBox_Errors.Name = "textBox_Errors";
            this.textBox_Errors.ReadOnly = true;
            this.textBox_Errors.Size = new System.Drawing.Size(350, 160);
            this.textBox_Errors.TabIndex = 7;
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(27, 309);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(725, 60);
            this.button_Clear.TabIndex = 8;
            this.button_Clear.Text = "CLEAR";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox informationFORMULA;
        private System.Windows.Forms.TextBox informationME;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.TextBox textBox_answer;
        private System.Windows.Forms.Label label_info_n;
        private System.Windows.Forms.Button button_Calculate;
        private System.Windows.Forms.TextBox textBox_ErrorCode;
        private System.Windows.Forms.TextBox textBox_Errors;
        private System.Windows.Forms.Button button_Clear;
    }
}

