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
    public partial class Billboard : Form
    {
        public int id, billboard_id, total;
        private string constring = "Server = localhost; Port=5432;Database=ad;User Id = postgres; Password=2523";

        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        NpgsqlDataReader sqlReader = null;
        public Billboard(int id, int billboard)
        {
            InitializeComponent();

            this.id = id;
            this.billboard_id = billboard;
            pictureBox1.Image = Image.FromFile("..\\..\\..\\billboards\\" + billboard + ".jpg");
            conn = new NpgsqlConnection(constring);
        }

        private void Billboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            DateTime dateEnd = dateTimePicker1.Value;
            total = (dateEnd.Date - dateTime.Date).Days*1000;
            label2.Text = "Сумма договора: "+total.ToString()+" руб.";
            if (total <= 0) { label2.Text = "Некоректно"; }
        }

        private void deal_btn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = "UPDATE billboards  SET customer_id = @id, enddate = @date, price = @price WHERE id = @id_;";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("date", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("price", total);
                cmd.Parameters.AddWithValue("id_", billboard_id);
                cmd.ExecuteNonQuery();

                conn.Close();
            }

            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error" + ex.Message);
            }
            deal_btn.Enabled = false;

        }

        private void back_to_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            customer cus = new customer(id);
            cus.Show();
        }
    }
}
