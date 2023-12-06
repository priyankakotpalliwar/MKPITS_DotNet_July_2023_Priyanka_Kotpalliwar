using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bsal =Convert.ToInt32(textBox2.Text);
            string designation=Convert.ToString(comboBox1.Text);
            float bonus=0.00f;
            float totalsalary;
            string empname=Convert.ToString(textBox1.Text);
            richTextBox1.Text = empname;
           
            
            switch(designation) 
            {
                case "manager":
                    bonus = 5000;
                    break;
                case "clerk":
                    bonus = 3000;
                    break;
                case "peon":
                    bonus = 2000;
                    break;

            }
            totalsalary = bonus+bsal;
            if(checkBox1.Checked) 
            {
                richTextBox1.Text = "total salary " + totalsalary;
            }
            if(checkBox2.Checked) 
            {
                richTextBox1.Text = "bonus " + bonus;
            }
        }
    }
}
