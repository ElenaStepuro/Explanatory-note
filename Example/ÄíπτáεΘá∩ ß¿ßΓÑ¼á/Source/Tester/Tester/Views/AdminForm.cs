using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ShoolTester.Properties;
using Tester.Models;
using Tester.Properties;

namespace ShoolTester
{
    /// <summary>
    /// Администрирование тестов
    /// </summary>
    public partial class AdminForm : Form
    {
        Dictionary<int, Test> _tests;

        public AdminForm(Dictionary<int, Test> tests)
        {
            InitializeComponent();

            listBox_Testes.DisplayMember = "Name";
            _tests = tests;
            RefreshList();
        }

        /// <summary>
        /// Обновление списка тестов
        /// </summary>
        private void RefreshList()
        {
            _tests.Clear();
            _tests = DataBase.GetAllTests();
            listBox_Testes.Items.Clear();
            if (_tests.Count != 0)
                foreach (var t in _tests)
                    listBox_Testes.Items.Add(t.Value);
        }

        /// <summary>
        /// Выделение теста
        /// </summary>
        private void ListBoxTestesSelectedIndexChanged(object sender, EventArgs e)
        {
            // Кнопка удалить
            if (listBox_Testes.Items.Count != 0 && listBox_Testes.SelectedIndex != -1)
                button_DeleteTest.Enabled = true;
            else
                button_DeleteTest.Enabled = false;

            // Вывод краткой информации о тесте
            if (_tests.Count != 0 && listBox_Testes.Items.Count != 0 && listBox_Testes.SelectedIndex != -1)
            {
                var t = (Test)listBox_Testes.SelectedItem;
                label_TimeConstr.Text = t.TimeConstraint.TimeOfDay.ToString();
                if (label_TimeConstr.Text == Resources.AdminForm_ListBoxTestesSelectedIndexChanged__00_00_00)
                    label_TimeConstr.Text = Resources.AdminForm_ListBoxTestesSelectedIndexChanged_Без_ограничения_;
                label_QuestCount.Text = t.QuestCount.ToString();
            }
        }

        /// <summary>
        /// Удаление теста
        /// </summary>
        private void button_DeleteTest_Click(object sender, EventArgs e)
        {
            if (listBox_Testes.SelectedItem != null)
            {
                var t = (Test)listBox_Testes.SelectedItem;
                DataBase.DeleteTest(t.Id);
                listBox_Testes.Items.RemoveAt(listBox_Testes.SelectedIndex);
            }
        }

        /// <summary>
        /// Добавление теста
        /// </summary>
        private void button_AddTest_Click(object sender, EventArgs e)
        {
            var addTestForm = new AddTestForm();
            Hide();
            var result = addTestForm.ShowDialog();
            if (result == DialogResult.OK ||result == System.Windows.Forms.DialogResult.Cancel )
            {
                button_DeleteTest.Enabled = false;
                Show();
                RefreshList();
            }
        }
    }
}
