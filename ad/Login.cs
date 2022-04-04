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
    public partial class Login : Form
    {
        private string constring = "Server = localhost; Port=5432;Database=ad;User Id = postgres; Password=2523";

        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        NpgsqlDataReader sqlReader = null;
        public int newid;
        public Login()
        {
            InitializeComponent();
            login_box.Visible = false;
            password_box.Visible = false;
            to_registrate_btn.Visible = false;
            to_login_btn.Visible = false;  

            conn = new NpgsqlConnection(constring);
            conn.Open();
            sql = @"select * from users ORDER BY id DESC LIMIT 1";
            cmd = new NpgsqlCommand(sql, conn);
            sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                newid = Convert.ToInt16(sqlReader["id"]);
            }
            conn.Close();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void back_to_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login_btn.Visible = false;
            registration_btn.Visible = false;

            login_box.Visible = true;
            password_box.Visible = true;
            to_registrate_btn.Visible = true;

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            to_login_btn.Visible = true;
            to_registrate_btn.Visible = false;
            login_btn.Visible = false;
            registration_btn.Visible = false;

            login_box.Visible = true;
            password_box.Visible = true;
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {

        }

        private void to_login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = "SELECT id FROM users WHERE login = @log AND password = @pass";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("log", login_box.Text);
                cmd.Parameters.AddWithValue("pass", password_box.Text);
                sqlReader = cmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    newid = Convert.ToInt16(sqlReader["id"]);
                }
                conn.Close();

                conn.Open();
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    this.Hide();
                    customer cus = new customer(newid);
                    cus.Show();
                }
                conn.Close();

            }

            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void registration_btn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = "INSERT INTO users (id, login, password) VALUES (@id, @log, @pass)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", newid + 1);
                cmd.Parameters.AddWithValue("log", login_box.Text);
                cmd.Parameters.AddWithValue("pass", password_box.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                this.Hide();
                customer cus = new customer(newid);
                cus.Show();
            }

            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error" + ex.Message);
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
