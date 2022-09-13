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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
           
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

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = "";
            bool isChecked = radioButton1.Checked;
            if (isChecked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }
            string sql = "insert into teacher values('" + textBox1.Text + "','" + gender + "','" + dateTimePicker1.Text +"','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox3.Text + "','" + richTextBox1.Text + "')";
          //  MessageBox.Show(sql);
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            int a = da.Fill(dt);
            if (a >= 0)
            {                              
                MessageBox.Show("your record id successfully inserted");
                Form5 f5 = new Form5();
                this.Hide();
                f5.Show();
                clear();
            }
            else
            {
                MessageBox.Show("please fill the form proper");
            }
        }
        private void clear()
        {
            textBox1.Text = "";
            
           
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePicker1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox3.Text = "";
            
            richTextBox1.Text = "";
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
