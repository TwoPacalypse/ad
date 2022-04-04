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
    public partial class customer : Form
    {
        private string constring = "Server = localhost; Port=5432;Database=ad;User Id = postgres; Password=2523";

        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        NpgsqlDataReader sqlReader = null;
        public int newid;
        public int id, billboard_id;
        public customer(int id)
        {
            InitializeComponent();
            this.id = id;
            label3.Text += id;
            conn = new NpgsqlConnection(constring);
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from billboards where customer_id IS NULL";
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

        private void customer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void back_to_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void viev_orders_Click(object sender, EventArgs e)
        {
            this.Hide();
            Orders orders = new Orders(id);
            orders.Show();
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            var selectedRow = dataGridView1.SelectedRows[0];
            billboard_id =  Convert.ToInt16(selectedRow.Cells[0].Value.ToString());
            Billboard bill = new Billboard(id, billboard_id);

            bill.Show();
        }
    }
}
