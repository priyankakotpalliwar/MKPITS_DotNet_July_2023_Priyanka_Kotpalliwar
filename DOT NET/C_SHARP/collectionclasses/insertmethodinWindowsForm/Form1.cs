using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insertmethodinWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList arr=new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            int frc=Convert.ToInt32(textBox1.Text);
            arr.Add(frc);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("capacity = " + arr.Capacity);
            MessageBox.Show("count = " + arr.Count);
            StringBuilder sb = new StringBuilder();
            foreach (object obj in arr) 
            {
                sb.Append("name = " + obj.ToString() + "\n");
            
            }
            richTextBox1.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            arr.Insert(2,textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
