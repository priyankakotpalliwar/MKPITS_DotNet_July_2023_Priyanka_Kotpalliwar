﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace integer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m, n;
            m=Convert.ToInt32(textBox1.Text);
            if(m>0)
            {
                n = 1;
            }
            else if(m==0) {
                n = 0;
            }
            else
            {
                n = -1;
            }
            textBox2.Text = "n is "+n;
        }
    }
}
