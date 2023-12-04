using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace advance_calcukator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int res = 0;
            switch(op)
            {
                case "+" :
                    res = pn + Convert.ToInt32(richTextBox1.Text);
                    break;
                case "-" :
                    res= pn-Convert.ToInt32(richTextBox1.Text);
                    break;
                case "*" :
                    res = pn * Convert.ToInt32(richTextBox1.Text);
                    break;
                case "/" :
                    res=pn/Convert.ToInt32(richTextBox1.Text);
                    break;

            }
            richTextBox1.Text=res.ToString();
            
          
            
           

        }
        int pn = 0;
        string op = null;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            pn = Convert.ToInt32(richTextBox1.Text);
            richTextBox1.Text = "/";
            op = "/";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "1";
            }
            else
            {
                if (op != null)
                {
                    if (richTextBox1.Text == "+" || richTextBox1.Text == "-" || richTextBox1.Text == "*" || richTextBox1.Text == "/")
                    {
                        richTextBox1.Clear();
                        richTextBox1.Text = richTextBox1.Text + "1";
                    }
                    else
                    {
                        richTextBox1.Text=richTextBox1.Text+"1";
                    }
                    
                }
                else
                {
                    richTextBox1.Text=richTextBox1.Text+"1";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "2";
            }
            else
            {
                if (op != null)
                {
                    if (richTextBox1.Text == "+" || richTextBox1.Text == "-" || richTextBox1.Text == "*" || richTextBox1.Text == "/")
                    {
                        richTextBox1.Clear();
                        richTextBox1.Text = richTextBox1.Text + "2" ;

                    }
                    else
                    {
                        richTextBox1.Text = richTextBox1.Text + "2";
                    }
                }
                else
                {
                    richTextBox1.Text=richTextBox1.Text+"2";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "3";
            }
            else
            {
                if (op != null)
                {

                    if (richTextBox1.Text == "+" || richTextBox1.Text == "-"||richTextBox1.Text=="*"||richTextBox1.Text=="/")
                    {

                        richTextBox1.Clear();
                        richTextBox1.Text = richTextBox1.Text + "3" ;
                    }
                    else
                    {
                      richTextBox1.Text = richTextBox1.Text + "3";
                    }
                }
                else
                {

                    richTextBox1.Text = richTextBox1.Text + "3";

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pn = Convert.ToInt32(richTextBox1.Text);
           richTextBox1.Text = "+";
            op = "+";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pn = Convert.ToInt32(richTextBox1.Text);
            richTextBox1.Text = "-";
            op = "-";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            pn = Convert.ToInt32(richTextBox1.Text);
            richTextBox1.Text = "*";
            op = "*";


        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}

