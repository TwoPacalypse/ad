using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace ad
{
    public partial class adminForm : Form
    {
        private string constring = "Server = localhost; Port=5432;Database=ad;User Id = postgres; Password=2523";

        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        NpgsqlDataReader sqlReader = null;
        public int newid;
        public adminForm()
        {
            InitializeComponent();

            conn = new NpgsqlConnection(constring);
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from billboards";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();

        }

        private void adminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = @"select * from billboards ORDER BY id DESC LIMIT 1";
            cmd = new NpgsqlCommand(sql, conn);
            sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                newid = Convert.ToInt16(sqlReader["id"]);

            }
            conn.Close();

            conn.Open();
            sql = "INSERT INTO billboards (id, location) VALUES (@id, @loc);";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("id", newid+1);
            cmd.Parameters.AddWithValue("loc", textBox1.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void back_to_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }
    }
}
