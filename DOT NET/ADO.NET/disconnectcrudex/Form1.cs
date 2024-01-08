using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace disconnectcrudex
{
    public partial class Form1 : Form
    {
        public string connectionstring { get; set; } = @"Data Source = .\sqlexpress01; Initial Catalog =CompanyCollebra ; Integrated Security = true;";
        SqlDataAdapter sqlda;
        DataSet dataSet;
        SqlCommandBuilder cb;

        public Form1()
        {
            InitializeComponent();
            sqlda = new SqlDataAdapter("select * from Employee",connectionstring);
            cb= new SqlCommandBuilder(sqlda);
            dataSet = new DataSet();
            sqlda.Fill(dataSet,"Emp_name");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = dataSet.Tables["Emp_name"].NewRow();
            dr[0]=textBox1.Text;
            dr[1]=textBox2.Text;
            dr[2]=textBox3.Text;
            dr[3]=Convert.ToInt16(textBox4.Text);
            dr[4]=textBox5.Text;
            dr[5]=textBox6.Text;
            dr[6]=Convert.ToInt16(textBox7.Text);

            dataSet.Tables["Emp_name"].Rows.Add(dr);
            sqlda.Update(dataSet.Tables["Emp_name"]);
            MessageBox.Show("Data Sucessfully Inserted..");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataSet.Tables["Emp_name"];

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(DataRow dr in dataSet.Tables["Emp_name"].Rows)
            {
                if (dr[0].ToString() == textBox1.Text)
                {
                    try
                    {
                        dr[0] = textBox1.Text;
                        dr[1] = textBox2.Text;
                        dr[2] = textBox3.Text;
                        dr[3] = Convert.ToInt16(textBox4.Text);
                        dr[4] = textBox5.Text;
                        dr[5] = textBox6.Text;
                        dr[6] = Convert.ToInt32(textBox7.Text);
                        sqlda.Update(dataSet.Tables["Emp_name"]);
                        MessageBox.Show("data updated succesfully");

                    }
                    catch(Exception ex) 
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

            }

        }
    }
}
