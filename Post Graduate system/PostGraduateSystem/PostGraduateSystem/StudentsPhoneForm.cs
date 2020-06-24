using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using CrystalDecisions.Shared;

namespace PostGraduateSystem
{
    public partial class StudentsPhoneForm : Form
    {
        Students_Phone SP;
        public StudentsPhoneForm()
        {
            InitializeComponent();
        }

        private void StudentsPhoneForm_Load(object sender, EventArgs e)
        {
            SP = new Students_Phone();
            crystalReportViewer1.ReportSource = SP;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            this.Hide();
            MF.Show();
        }

        private void StudentsPhoneForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
