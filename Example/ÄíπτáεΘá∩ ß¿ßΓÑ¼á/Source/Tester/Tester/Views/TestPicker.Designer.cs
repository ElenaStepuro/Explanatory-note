namespace ShoolTester
{
    partial class TestPicker
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
            this.comboBox_Tests = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_SeeResults = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TimeConstraint_label = new System.Windows.Forms.Label();
            this.QuestionCount_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_StartTest = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите тест";
            // 
            // comboBox_Tests
            // 
            this.comboBox_Tests.FormattingEnabled = true;
            this.comboBox_Tests.Location = new System.Drawing.Point(15, 50);
            this.comboBox_Tests.Name = "comboBox_Tests";
            this.comboBox_Tests.Size = new System.Drawing.Size(248, 21);
            this.comboBox_Tests.TabIndex = 1;
            this.comboBox_Tests.SelectedIndexChanged += new System.EventHandler(this.comboBox_Tests_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button_SeeResults);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button_StartTest);
            this.groupBox1.Controls.Add(this.comboBox_Tests);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 294);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор теста";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Выберите режим";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Режим обучения",
            "Режим тестирования"});
            this.comboBox1.Location = new System.Drawing.Point(15, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // button_SeeResults
            // 
            this.button_SeeResults.Location = new System.Drawing.Point(15, 225);
            this.button_SeeResults.Name = "button_SeeResults";
            this.button_SeeResults.Size = new System.Drawing.Size(152, 57);
            this.button_SeeResults.TabIndex = 4;
            this.button_SeeResults.Text = "Посмотреть результаты";
            this.button_SeeResults.UseVisualStyleBackColor = true;
            this.button_SeeResults.Click += new System.EventHandler(this.ButtonSeeResultsClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TimeConstraint_label);
            this.groupBox2.Controls.Add(this.QuestionCount_Label);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(15, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 85);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация о тесте";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ограничение по времени:";
            // 
            // TimeConstraint_label
            // 
            this.TimeConstraint_label.AutoSize = true;
            this.TimeConstraint_label.Location = new System.Drawing.Point(144, 52);
            this.TimeConstraint_label.Name = "TimeConstraint_label";
            this.TimeConstraint_label.Size = new System.Drawing.Size(0, 13);
            this.TimeConstraint_label.TabIndex = 2;
            // 
            // QuestionCount_Label
            // 
            this.QuestionCount_Label.AutoSize = true;
            this.QuestionCount_Label.Location = new System.Drawing.Point(105, 26);
            this.QuestionCount_Label.Name = "QuestionCount_Label";
            this.QuestionCount_Label.Size = new System.Drawing.Size(0, 13);
            this.QuestionCount_Label.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Число вопросов:";
            // 
            // button_StartTest
            // 
            this.button_StartTest.Image = global::Tester.Properties.Resources.start;
            this.button_StartTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_StartTest.Location = new System.Drawing.Point(188, 225);
            this.button_StartTest.Name = "button_StartTest";
            this.button_StartTest.Size = new System.Drawing.Size(75, 57);
            this.button_StartTest.TabIndex = 2;
            this.button_StartTest.Text = "Начать";
            this.button_StartTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_StartTest.UseVisualStyleBackColor = true;
            this.button_StartTest.Click += new System.EventHandler(this.ButtonStartTestClick);
            // 
            // TestPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 294);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TestPicker";
            this.Text = "Выбор режима работы";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Tests;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_StartTest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TimeConstraint_label;
        private System.Windows.Forms.Label QuestionCount_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_SeeResults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}