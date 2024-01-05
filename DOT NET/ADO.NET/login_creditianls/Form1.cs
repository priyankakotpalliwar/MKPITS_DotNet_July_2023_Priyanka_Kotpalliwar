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

namespace login_creditianls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string strcon = "server=.\\sqlexpress01;integrated security = true; database=Student_Connection";
        SqlConnection con = null;
        SqlCommand cmd = null;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(strcon);
                string qr = "select count (*) from users where username=@username and password=@password";
                cmd = new SqlCommand(qr, con);
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 20).Value = textBox1.Text;
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 20).Value = textBox2.Text;

                con.Open();
                int cnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (cnt > 0)


                    label4.Text = "login suceesfull";

                else

                    label4.Text = "invaild creditianls";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }

}
