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

namespace databaseconnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create connection with string
            string str = "server=.\\SQLEXPRESS01;integrated security=true;database=Student_Connection";
           
            SqlConnection con  = null;
            //use sql connection class to connect to sqlserver database
            try
            {
                con = new SqlConnection(str);
                con.Open();
                //in connected env. you have to explicitly open the connection using open method
                MessageBox.Show("connected succesfully");

            }
            catch(Exception ee) 
            {
                MessageBox.Show(ee.ToString());
            }
            finally 
            { 
                con.Close();
            }

        }
    }
}
