using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Studentinfo s = new Studentinfo();
            string g = null;
            if(radioButton1.Checked)
            {
                g = "male";

            }
            if(radioButton2.Checked) 
            {
                g = "female";
            }
            else if(radioButton3.Checked)
            {
                g = "transgender";
            }
            string h = null;
            if (checkBox1.Checked)
            {
                h = "siging";
            }
            if (checkBox2.Checked)
            {
                if (h != null)
                    h = h + ", " + "Dancing";
                else
                    h = "Dancing";
            }
            if (checkBox3.Checked)
            
                if (h != null)
                {
                    h = h + ", " + "Reading";
                }
                else
                {
                    h = "Reading";
                }

                string result = s.Insertstudent(Convert.ToInt32(textBox1.Text), textBox2.Text, g, h,
                    comboBox1.Text, dateTimePicker1.Value.ToShortDateString());
                richTextBox1.Text = result;
                cleartext();
            }
             public void cleartext()
            {
                textBox1.Clear();
                textBox2.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                comboBox1.Text = "";
                dateTimePicker1.Value = DateTime.Now;

            }

        private void button2_Click(object sender, EventArgs e)
        {
            Studentinfo s= new Studentinfo();
            string g = null;
            if(radioButton1.Checked) 
            {
                g = "male";
            }
            if(radioButton2.Checked) 
            {
                g = "female";
            }
            string h= null;
            if(checkBox1.Checked) 
            {
                h = "Singing";
            }
            if(checkBox2.Checked)
            {
                if(h!= null)
                {
                    h = h + "," + "Dancing";
                }
                else
                {
                    h = "Dancing";
                }
            }
            if(checkBox3.Checked)
            {
                if(h!= null)
                {
                    h = h + "," + "Reading";
                }
                else
                {
                    h = "reading";
                }
            }
            string result= s.Updatestudent(Convert.ToInt32(textBox1.Text),textBox2.Text,g,h,comboBox1.Text,dateTimePicker1.Value.ToShortDateString());

            richTextBox1.Text= result;
            cleartext();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Studentinfo s = new Studentinfo();
            string result= s.DeleteStudentdata(Convert.ToInt32(textBox1.Text),textBox2.Text);
            richTextBox1.Text= result;
            cleartext();
        }
    }
    }

