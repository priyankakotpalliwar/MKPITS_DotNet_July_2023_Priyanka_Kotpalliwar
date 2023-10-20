using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace eligibleforAdmission
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int physics;
            int chemistry;
            int mathematics;
            int total;
            string result = "null";
            physics=Convert.ToInt32(textBox1.Text);
            chemistry=Convert.ToInt32(textBox2.Text);
            mathematics=Convert.ToInt32(textBox3.Text);
            total=physics+mathematics+chemistry;
            textBox4.Text =  " total"+total;
            if (mathematics>=65  && physics>=55 && chemistry >= 50)
            {
                result = "eligible for addmission";

            }
            else if (total >= 140)
            {
                result = "eligible for addmission";
            }
            textBox5.Text = result;
        }
    }
}
