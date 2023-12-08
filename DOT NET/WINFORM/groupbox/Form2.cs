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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb= new StringBuilder();
            for(int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                sb.Append("course selected "+ checkedListBox1.CheckedItems[i]+"\n");
            }
            label1.Text = sb.ToString();    

        }
    }
}
