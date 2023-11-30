﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bank;

namespace accountinbank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Account1 act = null;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            act.accountno = Convert.ToInt32(textBox1.Text);
            string res=act.deposit(Convert.ToInt32(textBox2.Text));
            label4.Text = res;
                    
         }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="saving")
            {
                act = new saving();
            }
            else if(comboBox1.Text=="current")
            {
                act = new current();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            act.accountno= Convert.ToInt32(textBox1.Text);
            string res= act.withdrawl(Convert.ToInt32(textBox2.Text));
            label4.Text = res;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            act.accountno=Convert.ToInt32(textBox1.Text);
            string res = act.showbalance();
            label4.Text = res;
        }
    }
}
