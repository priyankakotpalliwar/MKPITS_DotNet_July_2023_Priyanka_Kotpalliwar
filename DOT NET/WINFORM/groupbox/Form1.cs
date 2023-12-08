using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groupbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (radioButton1.Checked )
            {
                sb.Append(radioButton1.Text+"\n");
            }
            else
            {
                sb.Append(radioButton2.Text+"\n");
            }
            label3.Text = "gender " + sb.ToString();
            StringBuilder ss = new StringBuilder();

            if (radioButton3.Checked ) 
            {
                ss.Append(radioButton3.Text + "\n");
            }
            else
            {
                ss.Append("java");
            }
            label4.Text = "course " + ss.ToString();


        }
    }
}
