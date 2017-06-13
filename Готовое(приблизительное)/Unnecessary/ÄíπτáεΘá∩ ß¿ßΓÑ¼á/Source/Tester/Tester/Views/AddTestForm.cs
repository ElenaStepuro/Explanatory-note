using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Tester.GUI;

namespace ShoolTester
{
    /// <summary>
    /// Форма для создания теста.
    /// </summary>
    public partial class AddTestForm : Form
    {
        readonly RadioListBox _radioListBox;
        readonly BindingList<Question> _bindingListQuestions = new BindingList<Question>();
        readonly BindingSource _bindingSource = new BindingSource();

        public AddTestForm()
        {
            InitializeComponent();
            _radioListBox = new RadioListBox { Location = new Point(9, 44), Size = new Size(190, 277) };
            _radioListBox.SelectedIndexChanged += RadioIndexChanged;
            groupBox2.Controls.Add(_radioListBox);

            _bindingSource.DataSource = _bindingListQuestions;
            listBoxQuestions.DataSource = _bindingSource;
            listBoxQuestions.DisplayMember = "Name";
        }

        /// <summary>
        /// Перевод из строки во время.
        /// </summary>
        private DateTime StringToTime(String time)
        {
            var buff = new char[255];
            time.CopyTo(0, buff, 0, time.IndexOf(':'));
            var hours = new string(buff);
            buff = new char[255];
            time.CopyTo(time.IndexOf(':') + 1, buff, 0, time.Length - time.IndexOf(':') - 1);
            var minutes = new string(buff);

            try
            {
                int h = Convert.ToInt16(hours.Trim());
                int m = Convert.ToInt16(minutes.Trim());
                return new DateTime(2012, 1, 1, h, m, 0);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// обновляем варианты отвтетов
        /// </summary>
        private void RefreshAnsvers()
        {
            _radioListBox.Items.Clear();
            var ans = _bindingListQuestions[GetQuestionSelectedIndex()].Ansvers;
            foreach (var temp in ans)
                temp.ID = _radioListBox.Items.Add(temp.Text);
        }

        /// <summary>
        /// Индекс выбранного вопроса
        /// </summary>
        private int GetQuestionSelectedIndex()
        {
            int id = 0;
            foreach (var t in _bindingListQuestions)
            {
                var q = (Question)listBoxQuestions.SelectedValue;
                if (q.Name == t.Name)
                    break;
                id++;
            }
            return id;
        }

        /// <summary>
        /// выделение ответа на вопрос
        /// </summary>
        void RadioIndexChanged(object sender, EventArgs e)
        {
            if (_radioListBox.SelectedIndex == -1)
                button_deleteAnsver.Enabled = false;
            else
                button_deleteAnsver.Enabled = true;
            // помечаем выбранный ответ как правельный
            _bindingListQuestions[GetQuestionSelectedIndex()].TrueAnsverID = _radioListBox.SelectedIndex;
        }

        /// <summary>
        /// Добавление вопроса
        /// </summary>
        private void ButtonAddQuestClick(object sender, EventArgs e)
        {
            AddQuestion addQuestionDialog = new AddQuestion();
            var result = addQuestionDialog.ShowDialog();
            // Добавляем пока просто вопрос без вариантов ответа.
            if (result == System.Windows.Forms.DialogResult.OK)
                _bindingListQuestions.Add(new Question(new List<Ansver>(), addQuestionDialog.QuestionName, -1, addQuestionDialog.Image, addQuestionDialog.ImageQuestion));
        }

        /// <summary>
        /// Добавление варианта ответа
        /// </summary>
        private void ButtonAddAnsverClick(object sender, EventArgs e)
        {
            var ansverName = "";
            if (InpuBox.InputBox("Введите ответ на вопрос.", "Ответ:", ref ansverName) == DialogResult.OK)
            {
                // Добавляем варианты ответов к выделенному вопросу
                _bindingListQuestions[GetQuestionSelectedIndex()].Ansvers.Add(new Ansver { Text = ansverName });
                _bindingListQuestions[GetQuestionSelectedIndex()].TrueAnsverID = _radioListBox.SelectedIndex;

                // обновляем варианты отвтетов
                RefreshAnsvers();
            }
        }

        /// <summary>
        /// Выбор вопроса
        /// </summary>
        private void ListBoxQuestionsSelectedIndexChanged(object sender, EventArgs e)
        {
            // кнопка удалить
            button_deleteQuest.Enabled = listBoxQuestions.SelectedIndex != -1;

            // кнопка добавить ответ
            button_AddAnsver.Enabled = listBoxQuestions.SelectedIndex != -1;

            // обновляем варианты отвтетов
            RefreshAnsvers();

            _radioListBox.SelectedIndex = _bindingListQuestions[GetQuestionSelectedIndex()].TrueAnsverID;
        }

        /// <summary>
        /// Добавление теста
        /// </summary>
        private void ButtonAddTestClick(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            int error = 0;
            if (textBox_TestName.Text == "")
                error = 1;

            // если с ограничением по времени 
            // то вытаскиваем время
            if (!checkBox_TimeConstraint.Checked)
            {
                try
                {
                    dt = StringToTime(maskedTextBox_DimeConstr.Text);
                }
                catch
                {
                    error = 2;
                }
            }
            else
                dt = new DateTime(1753, 1, 1, 0, 0, 0);
            // Проверяем на все ли вопросы есть ответы
            foreach (var t in _bindingListQuestions)
                if (t.TrueAnsverID == -1)
                    error = 3;
            // Проверяем у всех ли вопросов 
            // есть варианты ответов
            foreach (var t in _bindingListQuestions)
                if (t.Ansvers.Count < 1)
                    error = 4;

            // Есть ли в тесте вообще вопросы
            if (_bindingListQuestions.Count < 1)
                error = 5;

            // вывод ошибки
            switch (error)
            {
                case 1: MessageBox.Show("Введите имя теста."); break;
                case 2: MessageBox.Show("Не корректно введено время."); break;
                case 3: MessageBox.Show("Не выбраны верные ответы"); break;
                case 4: MessageBox.Show("Каждая задача должна содержать как минимум один вариант ответа."); break;
                case 5: MessageBox.Show("Тест должен состоять как минимум из одного вопроса"); break;
            }
            // Если ошибок нет
            if (error == 0)
            {
                DataBase.InsertTest(_bindingListQuestions, textBox_TestName.Text, dt);
                MessageBox.Show("Тест добавлен");
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        /// <summary>
        /// Отметили без огр по времени
        /// </summary>
        private void checkBox_TimeConstraint_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_TimeConstraint.Checked)
                maskedTextBox_DimeConstr.Enabled = false;
            else
                maskedTextBox_DimeConstr.Enabled = true;
        }

        /// <summary>
        /// Удаление варианта ответа
        /// </summary>
        private void button_deleteAnsver_Click(object sender, EventArgs e)
        {
            if (_radioListBox.SelectedIndex != -1)
            {
                // поиск ответа который нужно удалить
                Ansver deleted = new Ansver();
                foreach (var temp in _bindingListQuestions[GetQuestionSelectedIndex()].Ansvers)
                    if (temp.Text == (string)_radioListBox.SelectedItem)
                        deleted = temp;
                // Удаление
                _bindingListQuestions[GetQuestionSelectedIndex()].Ansvers.Remove(deleted);
                _radioListBox.Items.RemoveAt(_radioListBox.SelectedIndex);
            }
        }

        /// <summary>
        /// Удаление вопроса
        /// </summary>
        private void button_deleteQuest_Click(object sender, EventArgs e)
        {
            _bindingListQuestions.RemoveAt(GetQuestionSelectedIndex());
        }

        /// <summary>
        /// Закрытие
        /// </summary>
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
