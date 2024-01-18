using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                stype = "student";
            }
        }
        static string stype = "student";

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string state = DropDownList2.Text;
            DropDownList3.Items.Clear();
            switch (state)
            {
                case "Rajasthan":
                    DropDownList3.Items.Add("jaisalmer");
                    break;
                case "Punjab":
                    DropDownList3.Items.Add("Amritsar");
                    DropDownList3.Items.Add("Ludiana");
                    break;
                case "Maharashtra":
                    DropDownList3.Items.Add("Mumbai");
                    DropDownList3.Items.Add("nagpur");
                    break;
                case "Belgium":
                    DropDownList3.Items.Add("bruges");
                    DropDownList3.Items.Add("Namures");
                    break;
                case "crypus":
                    DropDownList3.Items.Add("ghent");
                    break;
                case "California":
                    DropDownList3.Items.Add("sanfranciso");
                    DropDownList3.Items.Add("sanjose");
                    break;
                case "LA":
                    DropDownList3.Items.Add("sanjose");
                    break;


            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("full name" + TextBox1.Text + "<br>");
            string gen = null;
            if(RadioButton1.Checked)
            {
               gen = RadioButton1.Text;
            }
            else if(RadioButton2.Checked)
            {
                gen = RadioButton2.Text;
            }
            else if(RadioButton3.Checked) 
            {
                gen = RadioButton3.Text;
            }
            else
            {
                Response.Write("please select gender");
            }


            sb.Append("gender "+gen+"<br>");

            string category = null;
            if(RadioButton4.Checked)
            {
                category = RadioButton4.Text;
            }
            else if(RadioButton5.Checked)
            {
                category = RadioButton5.Text;
            }
            else 
            {
                Response.Write("Please select the category");

            }
            sb.Append("category " + category + "<br>");
            sb.Append("Country " + DropDownList1.Text + "<br>");
            sb.Append("state " + DropDownList2.Text + "<br>");
            sb.Append("City " + DropDownList3.Text + "<br>");
            sb.Append("payment date " + TextBox2.Text + "<br>");


            Label15.Text=sb.ToString();
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c = DropDownList1.Text;
            DropDownList2.Items.Clear();
            switch(c)
            {
                case "India":
                    DropDownList2.Items.Add("Rajasthan"); 
                    DropDownList2.Items.Add("Maharashtra");
                    DropDownList2.Items.Add("Punjab");
                    
                    break;
                case "USA":
                    DropDownList2.Items.Add("California");
                    DropDownList2.Items.Add("LA");
                break;
                case "Europe":
                    DropDownList2.Items.Add("Belgium");
                    DropDownList2.Items.Add("crypus");
                    break;

                
            }
            
            



            
        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

            if (RadioButton4.Checked)

                stype = "student";
                TextBox3.Text = "10000";
                TextBox4.Text = "0";
                TextBox5.Text = "0";

            }

        protected void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButton5.Checked)
            {
                stype = "it";
                TextBox3.Text = "3000";
                TextBox4.Text = "0";    
                TextBox5.Text = "0";

            }
        }

        double bal = 0;
    protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

            if (stype == "student")
            {
                double fper = Convert.ToDouble(TextBox3.Text) * 0.5;
                if (Convert.ToDouble(TextBox4.Text) < fper)
                {
                    Label15.Text = " the amount paid should to more than 50%";
                }
                else
                {
                    bal = Convert.ToInt32(TextBox3.Text) - Convert.ToInt32(TextBox4.Text);
                    TextBox5.Text = bal.ToString();

                }
            }
            else if (stype == "it")
            {
                double fper = Convert.ToDouble(TextBox3.Text) * 0.8;
                if (Convert.ToDouble(TextBox4.Text) < fper)
                {
                    Label15.Text = "amount paid should be equal to 80 %";


                }
                else
                {
                    bal = Convert.ToInt32(TextBox4.Text) - Convert.ToInt32(TextBox3.Text)
                        ; TextBox5.Text = bal.ToString();
                }
            }


        }
    }
}