namespace ShoolTester
{
    partial class ResultForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.FIO_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AnsverCount_label = new System.Windows.Forms.Label();
            this.TrueAnsvers_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WrongAnsver_label = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Quest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isTrue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тест проходил(а):";
            // 
            // FIO_label
            // 
            this.FIO_label.AutoSize = true;
            this.FIO_label.Location = new System.Drawing.Point(12, 43);
            this.FIO_label.Name = "FIO_label";
            this.FIO_label.Size = new System.Drawing.Size(0, 13);
            this.FIO_label.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ответов дано:";
            // 
            // AnsverCount_label
            // 
            this.AnsverCount_label.AutoSize = true;
            this.AnsverCount_label.Location = new System.Drawing.Point(97, 72);
            this.AnsverCount_label.Name = "AnsverCount_label";
            this.AnsverCount_label.Size = new System.Drawing.Size(35, 13);
            this.AnsverCount_label.TabIndex = 3;
            this.AnsverCount_label.Text = "label3";
            // 
            // TrueAnsvers_label
            // 
            this.TrueAnsvers_label.AutoSize = true;
            this.TrueAnsvers_label.Location = new System.Drawing.Point(106, 99);
            this.TrueAnsvers_label.Name = "TrueAnsvers_label";
            this.TrueAnsvers_label.Size = new System.Drawing.Size(88, 13);
            this.TrueAnsvers_label.TabIndex = 4;
            this.TrueAnsvers_label.Text = "Верных ответов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Верных ответов:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Неверных ответов:";
            // 
            // WrongAnsver_label
            // 
            this.WrongAnsver_label.AutoSize = true;
            this.WrongAnsver_label.Location = new System.Drawing.Point(125, 132);
            this.WrongAnsver_label.Name = "WrongAnsver_label";
            this.WrongAnsver_label.Size = new System.Drawing.Size(0, 13);
            this.WrongAnsver_label.TabIndex = 7;
            // 
            // button_OK
            // 
            this.button_OK.Image = global::Tester.Properties.Resources.clean;
            this.button_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_OK.Location = new System.Drawing.Point(12, 390);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 29);
            this.button_OK.TabIndex = 12;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.ButtonOkClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quest,
            this.Answ,
            this.isTrue});
            this.dataGridView1.Location = new System.Drawing.Point(15, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 214);
            this.dataGridView1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tester.Properties.Resources.tests;
            this.pictureBox1.Location = new System.Drawing.Point(292, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Quest
            // 
            this.Quest.DataPropertyName = "Quest";
            this.Quest.HeaderText = "Вопрос";
            this.Quest.Name = "Quest";
            // 
            // Answ
            // 
            this.Answ.DataPropertyName = "Aansver";
            this.Answ.HeaderText = "Ответ";
            this.Answ.Name = "Answ";
            // 
            // isTrue
            // 
            this.isTrue.DataPropertyName = "TrueOrfalse";
            this.isTrue.HeaderText = "Правильность";
            this.isTrue.Name = "isTrue";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 444);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.WrongAnsver_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TrueAnsvers_label);
            this.Controls.Add(this.AnsverCount_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FIO_label);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ResultForm";
            this.Text = "Результаты:";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FIO_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AnsverCount_label;
        private System.Windows.Forms.Label TrueAnsvers_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label WrongAnsver_label;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answ;
        private System.Windows.Forms.DataGridViewTextBoxColumn isTrue;
    }
}