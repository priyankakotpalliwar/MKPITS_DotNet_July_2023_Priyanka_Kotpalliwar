using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insertMETHOD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList arr= new ArrayList();

        private void button1_Click(object sender, EventArgs e)
        {
            arr.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Capacity " + arr.Capacity);
            MessageBox.Show("count " + arr.Count);

            StringBuilder sb = new StringBuilder();

            foreach (object number in arr) 
            {
                sb.Append("numbr= "+number.ToString()+"\n");
            }
            label2.Text = sb.ToString();
        }
    }
}
