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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "delete addmision where registration_no ='"+comboBox1.Text+"' ";
            SqlDataAdapter da = new SqlDataAdapter(sql,Class1.cn);
            DataTable dt = new DataTable();
            int a = da.Fill(dt);
            if (a == 0)
            {
                MessageBox.Show("record successfully deleted");
                
                string sql1 = "select * from addmision";
                SqlDataAdapter da1 = new SqlDataAdapter(sql1, Class1.cn);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);

                comboBox1.DataSource = dt1;
                comboBox1.DisplayMember = "registration_no";

                dataGridView1.DataSource = dt1;
                Form5 f5 = new Form5();
                this.Hide();
                f5.Show();
            }

        }

        private void label13_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            string sql = "select * from addmision";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "registration_no";

            dataGridView1.DataSource = dt;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from addmision where registration_no='" + comboBox1.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        
        }
    }

