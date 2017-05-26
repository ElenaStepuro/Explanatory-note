using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ShoolTester.Properties;
using System.IO;
using Tester.Models;
using Tester.Properties;

namespace ShoolTester
{
    /// <summary>
    /// Форма для прохождения тестирования
    /// </summary>
    public partial class TesterForm : Form
    {
        readonly List<ResultRecord> _results = new List<ResultRecord>();
        readonly TestFlow _tf;
        Question _q;
        readonly int _max;

        /// <summary>
        /// Инициализация
        /// </summary>
        public TesterForm(TestFlow parTf)
        {
            InitializeComponent();

            _tf = parTf;
            _tf.TestTick += TfTestTick;
            _tf.TestFinished += TfTestFinished;
            _q = _tf.GetNextQuestion();

            if (_q.QuestionImage.Length != 0)
            {
                var ms = new MemoryStream(_q.QuestionImage);
                ms.Seek(0, SeekOrigin.Begin);
                pictureBox1.Image = System.Drawing.Image.FromStream(ms);
            }
            else
                pictureBox1.Image = null;

            textBox1.Text = _q.Name;
            for (int i = 0; i < _q.Count; i++)
                Ansvers_listBox.Items.Add(_q[i]);
            if (_tf.TimeConstraint().Hour == 0 && _tf.TimeConstraint().Minute == 0)
                label_Time_Last.Text = "Без ограничения по времени";

            _max = _tf.Span()._minutes * 60 + _tf.Span()._hours * 60 * 60 + _tf.Span()._seconds;
            progressBar1.Maximum = _max;
            QuestCount_label.Text = _tf.QuestionCount().ToString();
        }

        /// <summary>
        /// Вызывается если время вышло
        /// вставка результатов
        /// </summary>
        /// <param name="e"></param>
        void TfTestFinished(EventArgs e)
        {
            DataBase.InsertResults(_results);
            MessageBox.Show(Resources.TesterForm_TfTestFinished_Тест_завершон);

            List<ResultView> datasourse = DataBase.GetResults(_tf.ID, DataBase.UserId);

            var resultFormDoalog = new ResultForm(datasourse);
            Hide();

            if (resultFormDoalog.ShowDialog() == DialogResult.Cancel)
                Close();
        }

        /// <summary>
        /// Таймер
        /// </summary>
        void TfTestTick(EventArgs e)
        {
            label_Time_Last.Text = _tf.Span().ToString();
            if (progressBar1.Value < _max)
                progressBar1.Value = ++progressBar1.Value;
        }

        /// <summary>
        /// Кнопка ответа
        /// </summary>
        private void AnsverButtonClick(object sender, EventArgs e)
        {
            int current = Convert.ToInt32(QuestCount_label.Text);
            current--;
            QuestCount_label.Text = current.ToString();
            var res = new ResultRecord();
            string s = "";
            int ida = 0;
            // Если ответ выбран
            if (Ansvers_listBox.SelectedItem != null)
            {
                s = (string)Ansvers_listBox.SelectedItem;
                foreach (var r in _q.Ansvers)
                {
                    if (s == r.Text)
                        ida = r.ID;
                }

                // заполнение результата
                res.TestID = _tf.ID;
                res.Ans = ida;
                res.Trues = _q.TrueAnsverID;
                res.Quest = _q.ID;
                res.UserID = DataBase.UserId;
                _results.Add(res);

                // Следующий вопрос
                _q = _tf.GetNextQuestion();

                if (_q.QuestionImage != null && _q.QuestionImage.Length > 0)
                {
                    var ms = new MemoryStream(_q.QuestionImage);
                    ms.Seek(0, SeekOrigin.Begin);
                    pictureBox1.Image = System.Drawing.Image.FromStream(ms);
                }
                else
                    pictureBox1.Image = null;

                textBox1.Text = _q.Name;
                Ansvers_listBox.Items.Clear();
                for (int i = 0; i < _q.Count; i++)
                    Ansvers_listBox.Items.Add(_q[i]);
            }
        }
    }
}
