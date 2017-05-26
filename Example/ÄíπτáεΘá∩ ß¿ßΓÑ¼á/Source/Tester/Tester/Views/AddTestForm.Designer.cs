namespace ShoolTester
{
    partial class AddTestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxQuestions = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_AddQuest = new System.Windows.Forms.Button();
            this.button_deleteQuest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_AddAnsver = new System.Windows.Forms.Button();
            this.button_deleteAnsver = new System.Windows.Forms.Button();
            this.button_AddTest = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_TestName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox_DimeConstr = new System.Windows.Forms.MaskedTextBox();
            this.checkBox_TimeConstraint = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxQuestions
            // 
            this.listBoxQuestions.FormattingEnabled = true;
            this.listBoxQuestions.Location = new System.Drawing.Point(9, 44);
            this.listBoxQuestions.Name = "listBoxQuestions";
            this.listBoxQuestions.Size = new System.Drawing.Size(203, 277);
            this.listBoxQuestions.TabIndex = 0;
            this.listBoxQuestions.SelectedIndexChanged += new System.EventHandler(this.ListBoxQuestionsSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список вопросов:";
            // 
            // button_AddQuest
            // 
            this.button_AddQuest.Image = global::Tester.Properties.Resources.plus;
            this.button_AddQuest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_AddQuest.Location = new System.Drawing.Point(12, 339);
            this.button_AddQuest.Name = "button_AddQuest";
            this.button_AddQuest.Size = new System.Drawing.Size(95, 36);
            this.button_AddQuest.TabIndex = 2;
            this.button_AddQuest.Text = "Добавить";
            this.button_AddQuest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_AddQuest.UseVisualStyleBackColor = true;
            this.button_AddQuest.Click += new System.EventHandler(this.ButtonAddQuestClick);
            // 
            // button_deleteQuest
            // 
            this.button_deleteQuest.Enabled = false;
            this.button_deleteQuest.Image = global::Tester.Properties.Resources.cancel;
            this.button_deleteQuest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_deleteQuest.Location = new System.Drawing.Point(124, 339);
            this.button_deleteQuest.Name = "button_deleteQuest";
            this.button_deleteQuest.Size = new System.Drawing.Size(88, 36);
            this.button_deleteQuest.TabIndex = 3;
            this.button_deleteQuest.Text = "Удалить";
            this.button_deleteQuest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_deleteQuest.UseVisualStyleBackColor = true;
            this.button_deleteQuest.Click += new System.EventHandler(this.button_deleteQuest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Список ответов на вопрос:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_deleteQuest);
            this.groupBox1.Controls.Add(this.button_AddQuest);
            this.groupBox1.Controls.Add(this.listBoxQuestions);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 389);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вопросы:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_AddAnsver);
            this.groupBox2.Controls.Add(this.button_deleteAnsver);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(251, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 389);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ответы:";
            // 
            // button_AddAnsver
            // 
            this.button_AddAnsver.Enabled = false;
            this.button_AddAnsver.Image = global::Tester.Properties.Resources.plus;
            this.button_AddAnsver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_AddAnsver.Location = new System.Drawing.Point(9, 339);
            this.button_AddAnsver.Name = "button_AddAnsver";
            this.button_AddAnsver.Size = new System.Drawing.Size(90, 36);
            this.button_AddAnsver.TabIndex = 7;
            this.button_AddAnsver.Text = "Добавить";
            this.button_AddAnsver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_AddAnsver.UseVisualStyleBackColor = true;
            this.button_AddAnsver.Click += new System.EventHandler(this.ButtonAddAnsverClick);
            // 
            // button_deleteAnsver
            // 
            this.button_deleteAnsver.Enabled = false;
            this.button_deleteAnsver.Image = global::Tester.Properties.Resources.cancel;
            this.button_deleteAnsver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_deleteAnsver.Location = new System.Drawing.Point(121, 339);
            this.button_deleteAnsver.Name = "button_deleteAnsver";
            this.button_deleteAnsver.Size = new System.Drawing.Size(88, 36);
            this.button_deleteAnsver.TabIndex = 6;
            this.button_deleteAnsver.Text = "Удалить";
            this.button_deleteAnsver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_deleteAnsver.UseVisualStyleBackColor = true;
            this.button_deleteAnsver.Click += new System.EventHandler(this.button_deleteAnsver_Click);
            // 
            // button_AddTest
            // 
            this.button_AddTest.Image = global::Tester.Properties.Resources.clean;
            this.button_AddTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_AddTest.Location = new System.Drawing.Point(12, 515);
            this.button_AddTest.Name = "button_AddTest";
            this.button_AddTest.Size = new System.Drawing.Size(85, 32);
            this.button_AddTest.TabIndex = 8;
            this.button_AddTest.Text = "Ok";
            this.button_AddTest.UseVisualStyleBackColor = true;
            this.button_AddTest.Click += new System.EventHandler(this.ButtonAddTestClick);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Image = global::Tester.Properties.Resources.cancel__1_;
            this.button_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Cancel.Location = new System.Drawing.Point(372, 515);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(88, 32);
            this.button_Cancel.TabIndex = 9;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Название теста:";
            // 
            // textBox_TestName
            // 
            this.textBox_TestName.Location = new System.Drawing.Point(15, 25);
            this.textBox_TestName.Name = "textBox_TestName";
            this.textBox_TestName.Size = new System.Drawing.Size(432, 20);
            this.textBox_TestName.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ограничение по времени ЧЧ:ММ:";
            // 
            // maskedTextBox_DimeConstr
            // 
            this.maskedTextBox_DimeConstr.Location = new System.Drawing.Point(65, 68);
            this.maskedTextBox_DimeConstr.Mask = "00:00";
            this.maskedTextBox_DimeConstr.Name = "maskedTextBox_DimeConstr";
            this.maskedTextBox_DimeConstr.Size = new System.Drawing.Size(42, 20);
            this.maskedTextBox_DimeConstr.TabIndex = 13;
            this.maskedTextBox_DimeConstr.ValidatingType = typeof(System.DateTime);
            // 
            // checkBox_TimeConstraint
            // 
            this.checkBox_TimeConstraint.AutoSize = true;
            this.checkBox_TimeConstraint.Location = new System.Drawing.Point(209, 52);
            this.checkBox_TimeConstraint.Name = "checkBox_TimeConstraint";
            this.checkBox_TimeConstraint.Size = new System.Drawing.Size(174, 17);
            this.checkBox_TimeConstraint.TabIndex = 14;
            this.checkBox_TimeConstraint.Text = "Без ограничения по времени";
            this.checkBox_TimeConstraint.UseVisualStyleBackColor = true;
            this.checkBox_TimeConstraint.CheckedChanged += new System.EventHandler(this.checkBox_TimeConstraint_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tester.Properties.Resources.xclock;
            this.pictureBox1.Location = new System.Drawing.Point(18, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 36);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // AddTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 559);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox_TimeConstraint);
            this.Controls.Add(this.maskedTextBox_DimeConstr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_TestName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_AddTest);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddTestForm";
            this.Text = "Добавление нового теста";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxQuestions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_AddQuest;
        private System.Windows.Forms.Button button_deleteQuest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_AddAnsver;
        private System.Windows.Forms.Button button_deleteAnsver;
        private System.Windows.Forms.Button button_AddTest;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_TestName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_DimeConstr;
        private System.Windows.Forms.CheckBox checkBox_TimeConstraint;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}