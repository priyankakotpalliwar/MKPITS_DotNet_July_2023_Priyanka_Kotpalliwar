using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fendhal_projecta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        string strcon = "server=.\\sqlexpress01;integrated security= true;database=Fendahl_ProjectsA";
        SqlConnection con = null;
        DataSet ds = null;

        SqlDataAdapter da = null;

        
        private void Form1_Load(object sender, EventArgs e)

        {
            getnation();
            getstate();
            getcity();
            if (radioButton1.Checked)
                textBox2.Text = "10000";




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getstate(); 
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            getcity();
        }
            public void getnation()
            {
                try
                {
                    con = new SqlConnection(strcon);
                    ds = new DataSet();
                    da = new SqlDataAdapter("select * from table_nation order by Nation_ID", con);
                    da.Fill(ds, "table_nation");
                    comboBox1.DataSource = ds.Tables["table_nation"];
                    comboBox1.DisplayMember = "Nation_Name";
                    comboBox1.ValueMember = "Nation_ID";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        public void getstate()
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {

                try
                {
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from TableNation where @NationID=NationId", con);
                    da.SelectCommand.Parameters.AddWithValue("@NationID", comboBox1.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds,"TableState");
                    comboBox2.DataSource = ds.Tables["TableState"];
                    comboBox2.DisplayMember = "StateName";
                    comboBox2.ValueMember = "StateID";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }

        }
        public void getcity()
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from TableCity where StateID=@StateID", con);
                    da.SelectCommand.Parameters.AddWithValue("@StateID", comboBox2.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "TableCity");

                    comboBox3.DataSource = ds.Tables["TableCity"];
                    comboBox3.DisplayMember = "CityName";
                    comboBox3.ValueMember = "CityID";

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }
        }
        enum category {student,it_professional}
        enum gender {male,female,other}
        category cat;
        gender gen;

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text== "")
            {
                MessageBox.Show("full name can't be blank");

            }
            else
            {
                if(radioButton1.Checked)
                {
                    cat = category.student;
                }
                else if(radioButton2.Checked)
                {
                    cat=category.it_professional;
                }
                MessageBox.Show("category" + cat);
                if(radioButton3.Checked)
                {
                    gen = gender.male;
                }
                 else if(radioButton4.Checked) 
                {
                    gen=gender.female;
                }
                else if (radioButton5.Checked)
                {
                    gen=gender.other;
                }
                MessageBox.Show("gender selected succesfully"+gen);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            calculatefees();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                cat = category.it_professional;
                textBox2.Text = "3000";
                textBox3.Text = "0";
                textBox4.Text= "0";
            }
        }
        public void calculatefees()
        {
            if(cat.ToString()=="student")
            {
                textBox2.Text = "10000";
                float ta= Convert.ToSingle(textBox2.Text);
                float fp = ta * 0.5f;
                float amt=Convert.ToSingle(textBox3.Text);
                if(amt>fp) 
                {
                    MessageBox.Show("minimum amount to be paid is 50 per");
                }
                else 
                {
                    float bmt = ta - amt;
                    textBox4.Text=bmt.ToString();
                }
                

            }
            else if(cat.ToString()=="it_professional")
            {
                textBox2.Text = "3000";
                float ta = Convert.ToSingle(textBox2.Text);
                float fp = ta * 0.8f;
                float amt=Convert.ToSingle(textBox3.Text);  
                if(amt<fp)
                {
                    MessageBox.Show("minimum amount to be paid");

                }
                else
                { 
                    float bmt = ta - amt;
                    textBox4.Text=bmt.ToString();
                }

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked) 
            {
                cat = category.student;
                textBox2.Text = "1000";
                textBox3.Text = "0";
                textBox4.Text = "0";
            }
        }
    }
}