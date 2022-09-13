using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace collegemanagemantsystem181021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         int startpos = 0;
         string dot = ".";
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 1;
            progressBar1.Value = startpos;

            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                new Form2().Show();
            }

            label2.Text = dot;
            if (startpos % 3 == 0)
                dot = ".";
            else
                dot += ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();    
        }

        


        }
         

        }
    

