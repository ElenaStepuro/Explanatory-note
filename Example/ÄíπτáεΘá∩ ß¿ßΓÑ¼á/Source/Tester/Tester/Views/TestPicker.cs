using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tester.Models;

namespace ShoolTester
{
    public partial class TestPicker : Form
    {
        public int TestID;
        private TestFlow _tf;
        readonly Dictionary<int, Test> _tests;

        public TestPicker()
        {
            InitializeComponent();
        }

        public TestPicker(Dictionary<int, Test> tests)
        {
            InitializeComponent();
            foreach (var t in tests)
                comboBox_Tests.Items.Add(t.Value.Name);
            _tests = tests;
        }

        private void GetTestID()
        {
            if (comboBox_Tests.SelectedIndex != -1)
            {
                var s = (string)comboBox_Tests.Items[comboBox_Tests.SelectedIndex];

                foreach (var t in _tests)
                {
                    if (t.Value.Name == s)
                        TestID = t.Key;
                }
            }
            else
                throw new System.ArgumentException("Не выбран елемент");
        }

        private void ButtonStartTestClick(object sender, EventArgs e)
        {
            GetTestID();
            DataBase.ClearResults(DataBase.UserId, TestID);

            _tf = DataBase.FillTest(TestID);
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        var learnForm = new LearnForm(_tf);
                        Hide();
                        _tf.Start();
                        if (learnForm.ShowDialog() == DialogResult.Cancel)
                            Show();
                        break;
                    }
                case 1:
                    {
                        var testreForm = new TesterForm(_tf);
                        Hide();
                        _tf.Start();
                        if (testreForm.ShowDialog() == DialogResult.Cancel)
                            Show();
                        break;
                    }
                case -1: { MessageBox.Show("Выберите режим"); break; }
            }
        }

        private void ButtonSeeResultsClick(object sender, EventArgs e)
        {
            GetTestID();

            List<ResultView> datasourse = DataBase.GetResults(TestID, DataBase.UserId);
            var resultFormDoalog = new ResultForm(datasourse);
            resultFormDoalog.Show();
        }

        private void comboBox_Tests_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetTestID();
                QuestionCount_Label.Text = _tests[TestID].QuestCount.ToString();
                TimeConstraint_label.Text = _tests[TestID].TimeConstraint.TimeOfDay.ToString();
                if (TimeConstraint_label.Text == "00:00:00")
                    TimeConstraint_label.Text = "Без ограничения";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
