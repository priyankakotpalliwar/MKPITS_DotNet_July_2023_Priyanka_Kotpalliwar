using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int result;
        protected void Button1_Click(object sender, EventArgs e)
        {


            int n1 = Convert.ToInt32(TextBox1.Text);
            int n2 = Convert.ToInt32(TextBox2.Text);


            result = n1+ n2;
            TextBox3.Text = result.ToString();
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            int n1 = Convert.ToInt32(TextBox1.Text);
            int n2 = Convert.ToInt32(TextBox2.Text);
            result= n1- n2;
            TextBox3.Text = result.ToString();  
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            int n1 = Convert.ToInt32(TextBox1.Text);
            int n2 = Convert.ToInt32(TextBox2.Text);
            result= n1/n2;
            TextBox3.Text= result.ToString();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int n1=Convert.ToInt32(TextBox1.Text);  
            int n2= Convert.ToInt32(TextBox2.Text); 
            result= n1* n2;
           TextBox3.Text= result.ToString();

        }
    }
}