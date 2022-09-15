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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sas = new SqlDataAdapter("select * from login where email='" + textBox1.Text + "'", Class1.cn);
            DataTable dts = new DataTable();
            int a = sas.Fill(dts);
            if (a > 0)
            {
                string sql = "update login set password='" + textBox2.Text + "' where email='" + textBox1.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
                DataTable dt = new DataTable();
                int b = da.Fill(dt);
                if (b == 0)
                {
                    MessageBox.Show("Successfully reset your password.", "Information", MessageBoxButtons.OK);
                    Form2 f2 = new Form2();
                    this.Hide();
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("Something went wrong.");
                }
            }
            else
            {
                MessageBox.Show("Email doesn't exist.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
             
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
