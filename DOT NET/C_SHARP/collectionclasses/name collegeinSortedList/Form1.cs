﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace name_collegeinSortedList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        SortedList s1=new SortedList();
        private void button1_Click(object sender, EventArgs e)
        { 
            s1.Add(textBox1.Text, textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb= new StringBuilder();
            ICollection key = s1.Keys;
            foreach(string s in key)
            {
                sb.Append("name   -  "+ s + "college - " + s1[s]+"\n");
            }
            richTextBox1.Text= sb.ToString();
        }
    }
}
