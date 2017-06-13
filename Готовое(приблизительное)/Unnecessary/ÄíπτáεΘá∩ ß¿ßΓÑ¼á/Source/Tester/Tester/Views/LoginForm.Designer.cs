namespace ShoolTester
{
    partial class LoginForm
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
            this.Login_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Pass_textBox = new System.Windows.Forms.TextBox();
            this.Login_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Register_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_button
            // 
            this.Login_button.Image = global::Tester.Properties.Resources.door_in__3_;
            this.Login_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Login_button.Location = new System.Drawing.Point(16, 120);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(121, 33);
            this.Login_button.TabIndex = 2;
            this.Login_button.Text = "Вход";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.LoginButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин:";
            // 
            // Pass_textBox
            // 
            this.Pass_textBox.Location = new System.Drawing.Point(16, 94);
            this.Pass_textBox.Name = "Pass_textBox";
            this.Pass_textBox.PasswordChar = '*';
            this.Pass_textBox.Size = new System.Drawing.Size(250, 20);
            this.Pass_textBox.TabIndex = 1;
            // 
            // Login_textBox
            // 
            this.Login_textBox.Location = new System.Drawing.Point(16, 44);
            this.Login_textBox.Name = "Login_textBox";
            this.Login_textBox.Size = new System.Drawing.Size(250, 20);
            this.Login_textBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль:";
            // 
            // Register_button
            // 
            this.Register_button.Image = global::Tester.Properties.Resources.user_blue_add;
            this.Register_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Register_button.Location = new System.Drawing.Point(15, 194);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(134, 35);
            this.Register_button.TabIndex = 5;
            this.Register_button.Text = "Регистрация";
            this.Register_button.UseVisualStyleBackColor = true;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Login_textBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Login_button);
            this.groupBox1.Controls.Add(this.Pass_textBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 170);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вход в систему тестирования";
            // 
            // button3
            // 
            this.button3.Image = global::Tester.Properties.Resources.options;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(193, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "Настройки";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 233);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Register_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(331, 267);
            this.Name = "LoginForm";
            this.Text = "Система тестирования";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pass_textBox;
        private System.Windows.Forms.TextBox Login_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
    }
}

