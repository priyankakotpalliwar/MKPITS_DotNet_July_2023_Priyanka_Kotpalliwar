using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace displaynumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            display d1 = new display();
            int n= Convert.ToInt32(textBox1.Text);
          string a =  d1.call(n);
            richTextBox1.Text= a.ToString();

        }
    }
}
