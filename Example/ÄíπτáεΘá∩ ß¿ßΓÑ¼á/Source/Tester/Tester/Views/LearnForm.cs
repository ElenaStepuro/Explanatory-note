using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ShoolTester.Properties;
using System.IO;
using Tester.Models;

namespace ShoolTester
{
    public partial class LearnForm : Form
    {
        readonly List<ResultRecord> _results = new List<ResultRecord>();
        readonly TestFlow _tf;
        Question _q;
        MemoryStream ms;
        int currentQuest = 1;

        public LearnForm()
        {
            InitializeComponent();
        }


        public LearnForm(TestFlow parTf)
        {
            InitializeComponent();

            _tf = parTf;
            _q = _tf.GetNextQuestion();
            ms = new MemoryStream(_q.Image);
            ms.Seek(0, SeekOrigin.Begin);
            pictureBox1.Image = System.Drawing.Image.FromStream(ms);

            if (_q.QuestionImage.Length != 0)
            {
                ms = new MemoryStream(_q.QuestionImage);
                ms.Seek(0, SeekOrigin.Begin);
                pictureBox2.Image = System.Drawing.Image.FromStream(ms);
            }
            else
                pictureBox2.Image = null;


            textBox1.Text = _q.Name;
            for (int i = 0; i < _q.Count; i++)
                Ansvers_listBox.Items.Add(_q[i]);
            QuestCount_label.Text = currentQuest.ToString();
            label3.Text = _tf.QuestionCount().ToString();
            foreach (var tr in _q.Ansvers)
                if (tr.ID == _q.TrueAnsverID)
                    label5.Text = tr.Text;
        }

        // NEXT
        private void button2_Click(object sender, EventArgs e)
        {
            if (_tf.QuestionCount() > _tf.Current + 1)
            {
                ms = new MemoryStream(_q.Image);
                ms.Seek(0, SeekOrigin.Begin);
                pictureBox1.Image = System.Drawing.Image.FromStream(ms);

                currentQuest = _tf.Current + 2;
                QuestCount_label.Text = currentQuest.ToString();
                _q = _tf.GetNextQuestion();

                ms = new MemoryStream(_q.Image);
                ms.Seek(0, SeekOrigin.Begin);
                pictureBox1.Image = System.Drawing.Image.FromStream(ms);

                if (_q.QuestionImage.Length != 0)
                {
                    ms = new MemoryStream(_q.QuestionImage);
                    ms.Seek(0, SeekOrigin.Begin);
                    pictureBox2.Image = System.Drawing.Image.FromStream(ms);
                }
                else
                    pictureBox2.Image = null;

                foreach (var tr in _q.Ansvers)
                    if (tr.ID == _q.TrueAnsverID)
                        label5.Text = tr.Text;

                textBox1.Text = _q.Name;
                Ansvers_listBox.Items.Clear();
                for (int i = 0; i < _q.Count; i++)
                    Ansvers_listBox.Items.Add(_q[i]);
            }
        }


        // Back
        private void button1_Click(object sender, EventArgs e)
        {
            if (_tf.Current > 0)
            {
                currentQuest = currentQuest - 1;
                QuestCount_label.Text = currentQuest.ToString();
                _q = _tf.GetBackQuestion();

                ms = new MemoryStream(_q.Image);
                ms.Seek(0, SeekOrigin.Begin);
                pictureBox1.Image = System.Drawing.Image.FromStream(ms);

                if (_q.QuestionImage.Length != 0)
                {
                    ms = new MemoryStream(_q.QuestionImage);
                    ms.Seek(0, SeekOrigin.Begin);
                    pictureBox2.Image = System.Drawing.Image.FromStream(ms);
                }
                else
                    pictureBox2.Image = null;


                foreach (var tr in _q.Ansvers)
                    if (tr.ID == _q.TrueAnsverID)
                        label5.Text = tr.Text;

                textBox1.Text = _q.Name;
                Ansvers_listBox.Items.Clear();
                for (int i = 0; i < _q.Count; i++)
                    Ansvers_listBox.Items.Add(_q[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
