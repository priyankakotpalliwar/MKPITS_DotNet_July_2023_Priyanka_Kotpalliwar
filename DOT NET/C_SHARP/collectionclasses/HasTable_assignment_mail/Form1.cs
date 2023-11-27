using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HasTable_assignment_mail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hashtable ht =new Hashtable();
        StringBuilder sb = new StringBuilder();
        Student std;
        private void button1_Click(object sender, EventArgs e)
        {
            int rol=Convert.ToInt32(textBox1.Text);
            string name= textBox2.Text;
            std=new Student(rol, name);
            ht.Add(rol, name);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rt=Convert.ToInt32(textBox1.Text);
            ICollection key = ht.Keys;
            
            foreach (int s in key)
            {
                if(s == rt)
                    sb.Append("rol num: " + s.ToString() + "\t Name: " + ht[s].ToString() + "\n");
            }
            richTextBox1.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ICollection key = ht.Keys;

            foreach (int s in key)
            {
                sb.Append("rol num: " + s + "\t Name: " + ht[s]+"\n");
            }
                richTextBox1.Text = sb.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int rt = Convert.ToInt32(textBox1.Text);
            ICollection key = ht.Keys;

            foreach (int s in key)
            {
                if (s == rt)
                    sb.Remove(s);
            }
            richTextBox1.Text = sb.ToString();
        }
    }
}
