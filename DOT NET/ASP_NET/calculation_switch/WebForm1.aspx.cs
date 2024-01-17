﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calculation_switch
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(TextBox1.Text);
            int n2 = Convert.ToInt32(TextBox2.Text);
            char op = Convert.ToChar(TextBox3.Text);
            int res = 0;
            switch (op)
            {
                case '+':
                    res = n1 + n2;
                    break;

                case '-':
                    res = n1 - n2;
                    break;
                case '*':
                    res = n1 * n2;
                    break;
                case '/':
                    res = n1 / n2;
                    break;
                    
                default:
                    Response.Write("invalid operations");
                    
                    break;
            }
            TextBox4.Text = res.ToString();


        }
    }
}