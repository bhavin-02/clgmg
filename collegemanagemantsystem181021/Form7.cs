using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace collegemanagemantsystem181021
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            string sql = "select * from addmision";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "registration_no";
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Application.Exit();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "update addmision set semester='" + comboBox2.Text + "' where registration_no = '" + comboBox3.Text + "'";
           // MessageBox.Show(sql);
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            int a = da.Fill(dt);

            if (a <= 0)
            {
                MessageBox.Show("Record successfully updated.");
                Form5 f5 = new Form5();
                this.Hide();
                f5.Show();
            }
            else
            {
                MessageBox.Show("Please select semester");
            }
        }

      
        private void label13_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql ="select * from addmision where registration_no ='"+comboBox3.Text+"'";
            SqlDataAdapter cn = new SqlDataAdapter(sql,Class1.cn);
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBox1.Text = dt.Rows[i][7].ToString();
                    
                }
            }
            else
            {
               comboBox1.Text = "0";
                
            }
        }

        private void lbl_heading_Click(object sender, EventArgs e)
        {

        }

      
        }

        
    }

