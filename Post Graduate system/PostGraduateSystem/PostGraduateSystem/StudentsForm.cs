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

namespace PostGraduateSystem
{
    public partial class StudentsForm : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public StudentsForm()
        {
            InitializeComponent();
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select student_id from student";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            dr.Close();
        }
        //Add Student
        private void Button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into STUDENT values(:student_id,:first_name,:last_name,:paid,:street,:city)";
            cmd.Parameters.Add("student_id", comboBox1.Text);
            cmd.Parameters.Add("first_name", textBox2.Text);
            cmd.Parameters.Add("last_name", textBox3.Text);
            if (checkBox1.Checked)
            {
                cmd.Parameters.Add("paid", 1);
            }
            else
            {
                cmd.Parameters.Add("paid", 0);
            }

            cmd.Parameters.Add("street", textBox4.Text);
            cmd.Parameters.Add("city", textBox5.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                comboBox1.Items.Add(comboBox1.Text);
                MessageBox.Show("New Student is Added!");
                comboBox1.Text = "";
                textBox2.Clear();
                textBox3.Clear();
                checkBox1.Checked = false;
                textBox4.Clear();
                textBox5.Clear();
            }
        }
        //Modify Student
        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "update STUDENT set first_name=:StudentFirst,last_name=:StudentLast,paid=:StudentPaid,street=:StudentStreet,city=:StudentCity" +
                " where student_id=:id";
            c.Parameters.Add("StudentFirst", textBox2.Text);
            c.Parameters.Add("StudentLast", textBox3.Text);
            if (checkBox1.Checked == true)
            {
                c.Parameters.Add("StudentPaid", "1");
            }
            else
            {
                c.Parameters.Add("StudentPaid", "0");
            }

            c.Parameters.Add("StudentStreet", textBox4.Text);
            c.Parameters.Add("StudentCity", textBox5.Text);
            c.Parameters.Add("id", comboBox1.SelectedItem.ToString());

            int r = c.ExecuteNonQuery();
            if (r != -1)
            {

                MessageBox.Show("Student is Modified!");

            }
        }
        string str;
        //View Student
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select first_name,last_name,paid,street,city from student where student_id=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", comboBox1.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr[0].ToString();
                textBox3.Text = dr[1].ToString();
                str = dr[2].ToString();
                if (str.Equals("1"))
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }
                textBox4.Text = dr[3].ToString();
                textBox5.Text = dr[4].ToString();

            }
            dr.Close();

            int cn;
            OracleCommand c2 = new OracleCommand();
            c2.Connection = conn;
            c2.CommandText = "coursecount";
            c2.CommandType = CommandType.StoredProcedure;
            c2.Parameters.Add("StudentID", comboBox1.SelectedItem.ToString());
            c2.Parameters.Add("CN", OracleDbType.Int32, ParameterDirection.Output);

            c2.ExecuteNonQuery();
            try
            {
                cn = Convert.ToInt32(c2.Parameters["CN"].Value.ToString());
            }
            catch
            {

                cn = 0;

            }
            textBox1.Text = cn.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "Delete from student where student_id=:id";
            c.Parameters.Add("id", comboBox1.Text);
            int r = c.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Student deleted");
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                textBox2.Clear();
                textBox3.Clear();
                checkBox1.Checked = false;
                textBox4.Clear();
                textBox5.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private void StudentsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            this.Hide();
            MF.Show();
        }

        private void StudentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



    }
}
