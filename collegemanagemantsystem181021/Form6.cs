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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender="";
            bool isChecked =radioButton1.Checked;
            if(isChecked)
            {
                gender=radioButton1.Text;
            }
            else
            {
                gender=radioButton2.Text;
            }

            string sql = "insert into addmision values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + gender + "','" + dateTimePicker1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox7.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox6.Text + "','" + comboBox3.Text + "','" + richTextBox1.Text + "')";
            SqlDataAdapter da = new SqlDataAdapter(sql,Class1.cn);
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
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox6.Text = "";
            richTextBox1.Text = "";
            textBox1.Focus();

        }

        private void Form6_Load(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image file (*.jpg;*.png;*.jpeg;*.gif)|*.jpg;*.png;*.jpeg;*.gif;*";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(open.FileName);

            }
            string location = open.FileName;
            textBox7.Text = location;
            string filenm = open.SafeFileName;

        }
        }

        
      

        

    
    }

