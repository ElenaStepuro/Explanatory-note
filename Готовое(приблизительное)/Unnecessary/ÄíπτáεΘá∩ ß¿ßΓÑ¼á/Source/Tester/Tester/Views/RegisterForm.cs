using System;
using System.Windows.Forms;

namespace ShoolTester
{
    public partial class RegisterForm : Form
    {
        public string FIO;
        public string Pass;
        public string Pass2;
        public string Login;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void ButtonAcceptClick(object sender, EventArgs e)
        {
            FIO = FIO_textBox.Text;
            Pass = Pass_textBox.Text;
            Pass2 = Pass2_textBox.Text;
            Login = Login_textBox.Text;
            if (FIO.Length < 3)
            {
                MessageBox.Show("Ошибка ввода фамилии.");
                return;
            }

            if (Login.Length < 3)
            {
                MessageBox.Show("Ошибка ввода логина.");
                return;
            }
            if (Pass != Pass2)
            {
                MessageBox.Show("Ошибка. Пароли не совпадают.");
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}