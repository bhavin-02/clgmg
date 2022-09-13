using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace collegemanagemantsystem181021
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "select * from login where Username='" + textBox1.Text + "' and password='" + textBox2.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            int a = da.Fill(dt);

            if (a > 0)
            {
                Form5 f5 = new Form5();
                this.Hide();
                f5.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username and password");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        bool show = true;
        private void show_hide_password_Click(object sender, EventArgs e)
        {
            if (show == true)
            {
                show_hide_password.Image = collegemanagemantsystem181021.Properties.Resources.off_visibility;
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                show_hide_password.Image = collegemanagemantsystem181021.Properties.Resources.visibility;
                textBox2.UseSystemPasswordChar = true;
            }
            show = (!show);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Application.Exit();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
