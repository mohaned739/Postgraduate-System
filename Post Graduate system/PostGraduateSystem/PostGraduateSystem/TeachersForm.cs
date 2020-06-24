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
    public partial class TeachersForm : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public TeachersForm()
        {
            InitializeComponent();
        }

        private void TeachersForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select teacher_id from teacher";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            dr.Close();
        }
        //Add Teacher
        private void Button1_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "insertteacher";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("TID", comboBox1.Text);
            c.Parameters.Add("FName", textBox2.Text);
            c.Parameters.Add("LName", textBox3.Text);
            c.Parameters.Add("St", textBox4.Text);
            c.Parameters.Add("Ct", textBox5.Text);
            c.ExecuteNonQuery();
            MessageBox.Show("Teacher is Added Successfully!");
     
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select first_name,last_name,street,city from teacher where teacher_id=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", comboBox1.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr[0].ToString();
                textBox3.Text = dr[1].ToString();
                textBox4.Text = dr[2].ToString();
                textBox5.Text = dr[3].ToString();
            }
            dr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "deleteteacher";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("id", comboBox1.Text);
            int r = c.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Teacher deleted");
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
            MessageBox.Show("Teacher deleted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand c2 = new OracleCommand();
            c2.Connection = conn;
            c2.CommandText = "updateteacher";
            c2.CommandType = CommandType.StoredProcedure;
            c2.Parameters.Add("TID", comboBox1.Text);
            c2.Parameters.Add("FName", textBox2.Text);
            c2.Parameters.Add("LName", textBox3.Text);
            c2.Parameters.Add("St", textBox4.Text);
            c2.Parameters.Add("Ct", textBox5.Text);
            c2.ExecuteNonQuery();
            MessageBox.Show("Teacher is Modified Successfully!");
        }

        private void TeachersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            this.Hide();
            MF.Show();
        }

        private void TeachersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
