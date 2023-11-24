using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_araylist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        student s;
        ArrayList ar  =new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            s= new student(Convert.ToInt32(textBox1.Text),textBox2.Text);
            ar.Add(s);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();

          
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(student st in ar) {
                sb.Append("rno" + s.rno + "name " + s.name + "\n");
            }
            richTextBox1.Text = sb.ToString();
        }
    }
}
