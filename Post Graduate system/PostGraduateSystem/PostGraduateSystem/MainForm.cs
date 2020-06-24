using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostGraduateSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnnouncementsForm AF = new AnnouncementsForm();
            this.Hide();
            AF.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentsForm SF = new StudentsForm();
            this.Hide();
            SF.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PaidStudentsForm PF = new PaidStudentsForm();
            this.Hide();
            PF.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TeachersForm TF = new TeachersForm();
            this.Hide();
            TF.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StudentsPhoneForm SPF = new StudentsPhoneForm();
            this.Hide();
            SPF.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            StudentGradesform SGF = new StudentGradesform();
            this.Hide();
            SGF.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CourseDetails CD = new CourseDetails();
            this.Hide();
            CD.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FindTeacherForm FTF = new FindTeacherForm();
            this.Hide();
            FTF.Show();
        }
    }
}
