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
    public partial class Orders : Form
    {
        public int id, total;
        private string constring = "Server = localhost; Port=5432;Database=ad;User Id = postgres; Password=2523";

        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        NpgsqlDataReader sqlReader = null;
        public Orders(int id)
        {
            InitializeComponent();

            open.Enabled = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            dateTimePicker1.Visible = false;
            newdeal_btn.Visible = false;

            this.id = id;
            label4.Text = "";
            conn = new NpgsqlConnection(constring);
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            conn.Open();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT * FROM billboards WHERE customer_id = @id";
            comm.Parameters.AddWithValue("id", id);
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                open.Enabled = true;

            }
            comm.Dispose();
            conn.Close();
        }

        private void Orders_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            customer cus = new customer(id);
            cus.Show();
        }

        private void open_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            open.Visible = false;
            label1.Visible = false;
            dateTimePicker1.Visible = true;

            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            newdeal_btn.Visible = true;

       


            var selectedRow = dataGridView1.SelectedRows[0];
            label3.Text = "Конец аренды: " + selectedRow.Cells[4].Value.ToString();

        }

        private void Orders_Load(object sender, EventArgs e)
        {

        }

        private void newdeal_btn_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.SelectedRows[0];
            try
            {
                conn.Open();
                sql = "UPDATE billboards  SET customer_id = @id, enddate = @date, price = @price WHERE id = @id_;";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("date", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("price", (int)selectedRow.Cells[3].Value+total);
                cmd.Parameters.AddWithValue("id_", (int)selectedRow.Cells[0].Value);
                cmd.ExecuteNonQuery();

                conn.Close();
            }

            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error" + ex.Message);
            }
            newdeal_btn.Enabled = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.SelectedRows[0];
            DateTime dateTime = (DateTime)selectedRow.Cells[4].Value;
            DateTime dateEnd = dateTimePicker1.Value;
            total = (dateEnd.Date - dateTime.Date).Days * 1000;
            label4.Text = "Сумма договора: " + total.ToString() + " руб.";
            if (total <= 0) { label2.Text = "Некоректно"; }
        }
    }
}
