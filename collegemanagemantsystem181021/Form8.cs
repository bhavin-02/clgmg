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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            string sql = "select * from addmision";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "registration_no";

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Form5 f5 = new Form5();
                this.Hide();
                f5.Show();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }



        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from addmision where registration_no='" + comboBox1.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    textBox1.Text = dt.Rows[i][1].ToString();
                    textBox3.Text = dt.Rows[i][10].ToString();
                }
            }
            else
            {
                textBox1.Text = "0";
                textBox3.Text = "null";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into fees values('" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            int a = da.Fill(dt);
            if (a >= 0)
            {

                MessageBox.Show("your record id successfully inserted");
                clear();
                Form5 f5 = new Form5();
                this.Hide();
                f5.Show();

            }
            else
            {
                MessageBox.Show("please fill the form proper");
            }
        }
        private void clear()
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
