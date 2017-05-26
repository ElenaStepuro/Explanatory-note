using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShoolTester
{
    public partial class ConnectionOptions : Form
    {
        public String Server { get; set; }
        public ConnectionOptions(String s)
        {
            InitializeComponent();
            textBox1.Text = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server = textBox1.Text;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
