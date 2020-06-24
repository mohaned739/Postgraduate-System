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
    

    public partial class StudentGradesform : Form
    {
        student_grades SG;

        public StudentGradesform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SG = new student_grades();

            foreach (ParameterDiscreteValue v in SG.ParameterFields[0].DefaultValues){
                ids_cmb.Items.Add(v.Value);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SG.SetParameterValue(0, ids_cmb.Text);
            crystalReportViewer1.ReportSource = SG;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            this.Hide();
            MF.Show();
        }

        private void StudentGradesform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
