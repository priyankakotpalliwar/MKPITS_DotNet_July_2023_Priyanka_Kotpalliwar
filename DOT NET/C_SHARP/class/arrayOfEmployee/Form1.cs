using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrayOfEmployee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee[] emp= new Employee[3];
        int cnt = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            emp[0]= new Employee();
            emp[1]= new Employee();
            emp[2]= new Employee();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt<3)
            {
                emp[cnt].Employeename=textBox1.Text;
                emp[cnt].EmployeeID=textBox2.Text;
                emp[cnt].Salary=Convert.ToInt32(textBox3.Text);
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
                if(cnt==3)
                {
                    textBox1.Enabled=false;
                    textBox2.Enabled=false;
                    textBox3.Enabled=false;
                    button1.Enabled=false;
                    button2.Enabled=true;
                    MessageBox.Show("Details of 3 Employees are Accepted: ");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Employee Details are "+"\n");
            for (int i = 0; i < 3; i++)
            {
                sb.Append("---------------------------------\n");
                sb.Append("Employee Name: " + emp[i].Employeename +"\n");
                sb.Append("Employee ID: " + emp[i].EmployeeID + "\n");
                sb.Append("Salary: " + emp[i].Salary + "\n");
                sb.Append("---------------------------------\n");
            }
            richTextBox1.Text= sb.ToString();
            int high = emp[0].Salary;
            int foundat=0;
            for (int i = 0;i < 3;i++)
            {
                if (high < emp[i].Salary)
                {
                    high = emp[i].Salary;
                    foundat = i;
                }
            }
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("---------------------------------\n");
            sb1.Append("Employee Name: " + emp[foundat].Employeename + "\n");
            sb1.Append("Employee ID: " + emp[foundat].EmployeeID + "\n");
            sb1.Append("Salary: " + emp[foundat].Salary + "\n");
            sb1.Append("---------------------------------\n");
            richTextBox2.Text= sb1.ToString();
        }

    }
}
