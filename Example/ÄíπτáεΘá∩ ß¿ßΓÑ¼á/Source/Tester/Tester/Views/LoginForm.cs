using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ShoolTester.Properties;
using System.Configuration;
using Tester.Models;
using Tester.Properties;

namespace ShoolTester
{

    /// <summary>
    /// Форма для входа в систему
    /// тестирования
    /// </summary>
    public partial class LoginForm : Form
    {
        private Dictionary<int, Test> _tests = new Dictionary<int, Test>();

        public LoginForm()
        {
            InitializeComponent();
            if (Settings.Default.Server == "")
            {
                ConnectionOptions ConOptDialog = new ConnectionOptions(Settings.Default.Server);
                var res = ConOptDialog.ShowDialog();
                if (res == System.Windows.Forms.DialogResult.OK)
                {
                    Settings.Default.Server = ConOptDialog.Server;
                    Settings.Default.Save();
                }
            }

            DataBase.Connect(Settings.Default.Server);
        }

        /// <summary>
        ///  Кнопка вход
        /// </summary>
        private void LoginButtonClick(object sender, EventArgs e)
        {
            // Пытаемся войти в систему.
            DataBase.Login(Login_textBox.Text, Pass_textBox.Text);
            // Если пользователь не админ
            if (DataBase.UserId >= 0)
            {
                _tests.Clear();
                _tests = DataBase.GetAllTests();
                if (!DataBase.IsAdmin)
                {
                    var testerPickerDialog = new TestPicker(_tests);
                    Hide();

                    if (testerPickerDialog.ShowDialog() == DialogResult.Cancel)
                        Show();
                }
                // Пользователь администратор
                if (DataBase.IsAdmin)
                {
                    var adminForm = new AdminForm(_tests);
                    Hide();

                    if (adminForm.ShowDialog() == DialogResult.Cancel)
                        Show();
                }
            }
            else
                // Ошибка входа в систему.
                MessageBox.Show(Resources.MainForm_LoginButtonClick_Неверно_введен_пароль_или_логин_);
        }

        /// <summary>
        /// Кнопка регистрации
        /// </summary>
        private void Register_button_Click(object sender, EventArgs e)
        {
            // вызов диалога регистрации
            var registerFormDialog = new RegisterForm();
            var result = registerFormDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Проверка ввода паролей
                if (registerFormDialog.Pass == registerFormDialog.Pass2)
                {
                    // Попытка регистрации пользователя.
                    int res = DataBase.AddNewUser(registerFormDialog.FIO, registerFormDialog.Pass, registerFormDialog.Login);
                    // вывод сообщения о регистрации
                    MessageBox.Show(res == 0
                                        ? Resources.MainForm_RegisterButtonClick_Вы_успешно_зарегестировались
                                        : Resources.MainForm_RegisterButtonClick_Регистрация_не_удачна);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConnectionOptions ConOptDialog = new ConnectionOptions(Settings.Default.Server);
            var res = ConOptDialog.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                Settings.Default.Server = ConOptDialog.Server;
                Settings.Default.Save();
            }
        }
    }
}
