using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basicsalaryplusbonus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee emp = new Employee();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string empname= textBox1.Text;
            int basesalary = Convert.ToInt32(textBox2.Text);
            string designation= textBox3.Text;
            int r=emp.count(basesalary,designation);
            richTextBox1.Text= r.ToString();

        }
    }
}
