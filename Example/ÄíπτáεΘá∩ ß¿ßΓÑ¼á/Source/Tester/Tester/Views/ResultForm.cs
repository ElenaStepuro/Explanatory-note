using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tester.Models;

namespace ShoolTester
{
    public partial class ResultForm : Form
    {
        public ResultForm(List<ResultView> ds)
        {
            InitializeComponent();
            dataGridView1.DataSource = ds;
            FIO_label.Text = DataBase.Fio; 
            AnsverCount_label.Text = ds.Count.ToString();

            IEnumerable<ResultView> truesCount =
            from trues in ds
            where trues.TrueOrfalse == "+"
            select trues;

            IEnumerable<ResultView> wrongCount =
            from wrong in ds
            where wrong.TrueOrfalse == "-"
            select wrong;

            TrueAnsvers_label.Text = truesCount.Count().ToString();
            WrongAnsver_label.Text = wrongCount.Count().ToString();
            
        }

        private void ButtonOkClick(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}
