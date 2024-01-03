using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace example1
{
    public partial class Form1 : Form
    {
        public static class databaseconnection
        {
            public static string strcon = "server=.\\sqlexpress01;integrated security=true;database=Student_Connection";

            public static SqlConnection GetConnection()
            {
                SqlConnection con = null;
                try
                {
                    con = new SqlConnection(strcon);
                    con.Open();
                    return con;

                }
                catch (Exception ee)
                {
                    return null;
                }
            }
        }
    
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = databaseconnection.GetConnection();
            if(con !=null)
            {
                MessageBox.Show("succesfully connected");
                con.Close();
            }
            else
            {
                MessageBox.Show("can't  connect to serever");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constr = "server=.\\SQLEXPRESS01;integrated security = true; database=Student_Connection";
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string strcmd = "insert into users values('" + textBox1.Text + "','" +textBox2.Text + "')";
                SqlCommand command = new SqlCommand(strcmd, con);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("record inserted succesfully");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string constr = "server=.\\sqlexpress01;integrated security=true;database=Student_Connection";
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string strcmd ="delete  from users where username= '" + textBox1.Text + "'or password ='" + textBox2.Text + "'";
                SqlCommand command = new SqlCommand(strcmd, con);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" record deleted sccesfully");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            catch (Exception ee) 
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string constr = "server=.\\sqlexpress01;integrated security = true;database=Student_Connection";
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string strmcd = "update users set password='"+textBox2.Text+ "' where username='" +textBox1.Text +"'";
                SqlCommand command = new SqlCommand(strmcd, con);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("sucessfully updated");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string constr = "server=.\\sqlexpress01;integrated security=true;database=Student_Connection";
            SqlConnection con = new SqlConnection(constr);  
            try
            {
                con.Open();
                string strmcd = "select * from users where username='" + textBox1.Text + "'";
                SqlCommand command = new SqlCommand(strmcd, con);
                SqlDataReader dr;
                int flag = 0;
                dr = command.ExecuteReader();
                while(dr.Read())
                {

                    flag = 1;
                    textBox2.Text = dr["password"].ToString();

                }
                dr.Close();
                con.Close();
                if(flag==0)
                {
                    MessageBox.Show("record not found");
                }
             
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

    }
}
