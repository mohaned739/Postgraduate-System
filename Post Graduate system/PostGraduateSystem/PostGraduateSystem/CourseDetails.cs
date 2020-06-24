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
    public partial class CourseDetails : Form
    {
        course_details CD;
        public CourseDetails()
        {
            InitializeComponent();
        }
        private void CourseDetails_Load(object sender, EventArgs e)
        {
            CD = new course_details();
            foreach (ParameterDiscreteValue v in CD.ParameterFields[0].DefaultValues)
            {
                course_namecmb.Items.Add(v.Value);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            CD.SetParameterValue(0, course_namecmb.Text);
            crystalReportViewer1.ReportSource = CD;
        }

        private void CourseDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            this.Hide();
            MF.Show();
        }

        private void CourseDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
