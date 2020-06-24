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
    public partial class PaidStudentsForm : Form
    {
        string ordb = "data source=orcl;user id=scott;password=tiger;";
        OracleConnection conn;
        public PaidStudentsForm()
        {
            InitializeComponent();
        }

        private void PaidStudentsForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            DataTable d1 = new DataTable();
            cmd.Connection = conn;
            cmd.CommandText = "STD";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ret_cur", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            d1.Load(dr);
            dataGridView1.DataSource = d1;
            dr.Close();
        }

        private void PaidStudentsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            this.Hide();
            MF.Show();
        }

        private void PaidStudentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
