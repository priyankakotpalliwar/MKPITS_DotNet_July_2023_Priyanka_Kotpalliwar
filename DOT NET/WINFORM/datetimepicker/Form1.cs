using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datetimepicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            MessageBox.Show(dateTimePicker1.Text);
            label1.Text = dateTimePicker1.Text;
            label2.Text=dateTimePicker1.Value.ToLongDateString();
            label3.Text = dateTimePicker1.Value.ToShortDateString();
            label4.Text = dateTimePicker1.Value.Date.Year.ToString();*/
            string age= dateTimePicker1.Text;
            MessageBox.Show("dob " + age);
            int yr=dateTimePicker1.Value.Year;
            MessageBox.Show("dob year " + yr);
            int cr=DateTime.Now.Year;
            MessageBox.Show("current year " + cr);
            int dif = cr - Convert.ToInt32(yr);
            MessageBox.Show("your'e age is "+dif);

        }
    }
}
