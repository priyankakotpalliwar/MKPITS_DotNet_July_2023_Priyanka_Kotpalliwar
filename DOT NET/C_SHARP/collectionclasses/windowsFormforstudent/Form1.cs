using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsFormforstudent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList al=new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            student s1=new student(Convert.ToInt32(textBox1.Text),textBox2.Text);
            student s2 = new student(Convert.ToInt32(textBox3.Text), textBox4.Text);
            al.Add(s1);
            al.Add(s2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb=new StringBuilder();   
            foreach(student s in al)
            {
                sb.Append("roll no - " + s.rollno + " name - " + s.name+"\n");
            }
            label3.Text = sb.ToString();
        }
    }
}
