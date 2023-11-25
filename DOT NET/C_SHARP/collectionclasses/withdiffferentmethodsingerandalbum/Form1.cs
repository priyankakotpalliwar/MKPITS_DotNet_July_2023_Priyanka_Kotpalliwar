﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace withdiffferentmethodsingerandalbum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hashtable ht=new Hashtable();
        private void button1_Click(object sender, EventArgs e)
        {
            ht.Add(textBox1.Text,textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            ICollection kt= ht.Keys;
            foreach(string so in  kt)
            {
             
                sb.Append("album name " + so + "\tsinger name " + ht[so]+"\n");
            }
            richTextBox1.Text = sb.ToString();   
        }
    }
}
