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

namespace sqladapter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server=.\\sqlexpress01;integrated security = true;database=MKPITS");
        DataSet ds = new DataSet();
        SqlDataAdapter ad;
        SqlCommandBuilder cb = null;


        private void button1_Click(object sender, EventArgs e)
        {
            ad=new SqlDataAdapter("select * from student", conn);
            cb= new SqlCommandBuilder(ad);
            ad.Fill(ds, "name");
            dataGridView1.DataSource = ds.Tables["name"];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ad.Update(ds.Tables["name"]);
                MessageBox.Show("record updated sucessfully");
            }
            catch(Exception ee) 
            {
                MessageBox.Show(ee.ToString());
                
            }
        }
    }
}
