namespace ShoolTester
{
    partial class AdminForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_DeleteTest = new System.Windows.Forms.Button();
            this.button_AddTest = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_TimeConstr = new System.Windows.Forms.Label();
            this.label_QuestCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelQuestionCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Testes = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_DeleteTest);
            this.groupBox1.Controls.Add(this.button_AddTest);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.listBox_Testes);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список тестов";
            // 
            // button_DeleteTest
            // 
            this.button_DeleteTest.Enabled = false;
            this.button_DeleteTest.Image = global::Tester.Properties.Resources.cancel;
            this.button_DeleteTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_DeleteTest.Location = new System.Drawing.Point(270, 184);
            this.button_DeleteTest.Name = "button_DeleteTest";
            this.button_DeleteTest.Size = new System.Drawing.Size(114, 37);
            this.button_DeleteTest.TabIndex = 3;
            this.button_DeleteTest.Text = "Удалить тест";
            this.button_DeleteTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_DeleteTest.UseVisualStyleBackColor = true;
            this.button_DeleteTest.Click += new System.EventHandler(this.button_DeleteTest_Click);
            // 
            // button_AddTest
            // 
            this.button_AddTest.Image = global::Tester.Properties.Resources.plus;
            this.button_AddTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_AddTest.Location = new System.Drawing.Point(270, 129);
            this.button_AddTest.Name = "button_AddTest";
            this.button_AddTest.Size = new System.Drawing.Size(114, 38);
            this.button_AddTest.TabIndex = 2;
            this.button_AddTest.Text = "Добавить тест";
            this.button_AddTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_AddTest.UseVisualStyleBackColor = true;
            this.button_AddTest.Click += new System.EventHandler(this.button_AddTest_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_TimeConstr);
            this.groupBox2.Controls.Add(this.label_QuestCount);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.labelQuestionCount);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(270, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация";
            // 
            // label_TimeConstr
            // 
            this.label_TimeConstr.AutoSize = true;
            this.label_TimeConstr.Location = new System.Drawing.Point(6, 63);
            this.label_TimeConstr.Name = "label_TimeConstr";
            this.label_TimeConstr.Size = new System.Drawing.Size(0, 13);
            this.label_TimeConstr.TabIndex = 4;
            // 
            // label_QuestCount
            // 
            this.label_QuestCount.AutoSize = true;
            this.label_QuestCount.Location = new System.Drawing.Point(132, 27);
            this.label_QuestCount.Name = "label_QuestCount";
            this.label_QuestCount.Size = new System.Drawing.Size(0, 13);
            this.label_QuestCount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ограничение по времени:";
            // 
            // labelQuestionCount
            // 
            this.labelQuestionCount.AutoSize = true;
            this.labelQuestionCount.Location = new System.Drawing.Point(132, 27);
            this.labelQuestionCount.Name = "labelQuestionCount";
            this.labelQuestionCount.Size = new System.Drawing.Size(0, 13);
            this.labelQuestionCount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество вопросов:";
            // 
            // listBox_Testes
            // 
            this.listBox_Testes.FormattingEnabled = true;
            this.listBox_Testes.Location = new System.Drawing.Point(6, 19);
            this.listBox_Testes.Name = "listBox_Testes";
            this.listBox_Testes.Size = new System.Drawing.Size(247, 277);
            this.listBox_Testes.TabIndex = 0;
            this.listBox_Testes.SelectedIndexChanged += new System.EventHandler(this.ListBoxTestesSelectedIndexChanged);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 312);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminForm";
            this.Text = "Администрирование";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox_Testes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelQuestionCount;
        private System.Windows.Forms.Button button_DeleteTest;
        private System.Windows.Forms.Button button_AddTest;
        private System.Windows.Forms.Label label_TimeConstr;
        private System.Windows.Forms.Label label_QuestCount;
    }
}