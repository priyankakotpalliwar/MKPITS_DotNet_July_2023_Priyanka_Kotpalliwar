using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }
        int scoreplayer = 3;
        private void button1_Click(object sender, EventArgs e)
        {
          
            


                if (radioButton3.Checked)
                {
                    scoreplayer++;
                }
                else
                {
                   
                }
                if (radioButton4.Checked)
                {
                    scoreplayer++;
                }
                else 
                {
                    
                    
                }
                if (radioButton7.Checked)
                {
                    scoreplayer++;
                }
                else
                {

                 

                }
                richTextBox1.Text = scoreplayer.ToString();
            }
            
        }
    }

