using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace getproperties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            person p= new person();
            p.Name = textBox1.Text;
            p.Age=Convert.ToInt32(textBox2.Text);
            p.Address = textBox3.Text;


            StringBuilder sb= new StringBuilder();
            sb.Append("name :"+p.Name+"\n");
            sb.Append("age: "+p.Age+"\n");
            sb.Append("addres : "+p.Address+"\n");
            richTextBox1.Text = sb.ToString();
        }
    }
}
