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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from addmision where registration_no ='" + comboBox4.Text + "'";
            SqlDataAdapter cn = new SqlDataAdapter(sql, Class1.cn);
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBox4.Text = dt.Rows[i][0].ToString();
                   label16.Text = dt.Rows[i][1].ToString();
                   label17.Text = dt.Rows[i][2].ToString();
                   label15.Text = dt.Rows[i][3].ToString();
                   
                   label18.Text = dt.Rows[i][4].ToString();
                   label19.Text = dt.Rows[i][5].ToString();
                   label20.Text = dt.Rows[i][6].ToString();
                   label21.Text = dt.Rows[i][7].ToString();
                   label22.Text = dt.Rows[i][8].ToString();
                   label23.Text = dt.Rows[i][9].ToString();
                   label24.Text = dt.Rows[i][10].ToString();
                   label25.Text = dt.Rows[i][11].ToString();
                }
            }
            else
            {
                comboBox4.Text = "0";
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            string sql = "select * from addmision";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBox4.DataSource = dt;
            comboBox4.DisplayMember = "registration_no";
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

        private void label14_Click(object sender, EventArgs e)
        {
                {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }
        }

    }
}
