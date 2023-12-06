using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creatingRegistrationForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("username - " + textBox1.Text+"\n");
            sb.Append("password - " + textBox1.Text + "\n"  );
            string gender = null;
            if(radioButton1.Checked)
            {
                gender=radioButton1.Text;
            }
            else if(radioButton2.Checked)
            {
                gender= radioButton2.Text;


            }
            sb.Append("gender - " + gender+"\n");
            sb.Append("country " + comboBox1.Text + "\n");

            sb.Append("city " + comboBox2.Text + "\n");


            richTextBox1.Text = sb.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = " ";
            switch(comboBox1.Text )
            {
                case "India":
                    comboBox2.Items.Add("Nagpur");
                    comboBox2.Items.Add("mumbai");
                    break;
                case "USA":
                    comboBox2.Items.Add("LA");
                    comboBox2.Items.Add("california");
                    break;

                    }
        }
    }
}
