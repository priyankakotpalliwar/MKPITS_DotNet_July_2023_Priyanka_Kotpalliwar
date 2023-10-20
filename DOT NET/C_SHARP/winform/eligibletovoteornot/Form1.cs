using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eligibletovoteornot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age;
            string result =null;
            age=Convert.ToInt32(textBox1.Text); 
            if(age >= 18) {
                result = "your eligilbe to vote";

            }
            else
            {
                result = "not eligible to vote";
            }
            textBox2.Text=result;
        }
    }
}
