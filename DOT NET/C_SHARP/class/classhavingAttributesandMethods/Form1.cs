using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classhavingAttributesandMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p= new Person();
            p.name = textBox1.Text;
            p.age=Convert.ToInt32(textBox2.Text);
            p.address=textBox3.Text;

            StringBuilder sb = new StringBuilder(); 
            sb.Append("name :"+p.name +"\n");
            sb.Append("age : "+p.age+"\n");
            sb.Append("address :"+p.address+"\n");
            richTextBox1.Text = sb.ToString();

        }
    }
}
