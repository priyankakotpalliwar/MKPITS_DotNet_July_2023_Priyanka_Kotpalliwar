using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Student_Info
{
    internal class Studentinfo
    {
        string strcon = "server=.\\sqlexpress01;integrated security = true;database=MKPITS";
        //CREATING A METHOD  to insert A RECORD IN STUDENT TABLE
        public string Insertstudent(int rno,string studname,string gender,string hobby,string city,string dob)
        {
            string strcon = "server=.\\sqlexpress01;integrated security = true;database=MKPITS";
            using (SqlConnection cmds = new SqlConnection(strcon))
            {

                cmds.Open();
                string str = "insert into Student_Info values(@rno,@studname,@gender,@hobby,@city,@DOB)";
                using (SqlCommand cmd = new SqlCommand(str,cmds))
                {
                    cmd.Parameters.AddWithValue("@rno", rno);
                    cmd.Parameters.AddWithValue("@studname", studname);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@hobby", hobby);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@DOB", dob);
                    cmd.ExecuteNonQuery();
                   cmds.Close();
                    return "record saved succesfully";



                }


            }
        }
        public string Updatestudent(int rno,string studname,string gender,string hobby,string city,
            string dob)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                String str = "update Student_Info  set studname=@studname,gender=@gender,hobby=@hobby,city=@city,DOB=@DOB where studname=@studname";
                using (SqlCommand cmd = new SqlCommand(str, con)) 
                {
                    cmd.Parameters.AddWithValue("@studname", studname);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@hobby", hobby);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@DOB", dob);
                    cmd.Parameters.AddWithValue("@rno", rno);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    return "record updated sucessfully";

                }

                   
            }
           
        }
        public string DeleteStudentdata(int rno,string studname)
        {
            using(SqlConnection con = new SqlConnection(strcon)) 
            {
            con.Open();
                string str = "delete from Student_Info where rno=@rno or studname=@studname";
                using(SqlCommand cmd = new SqlCommand(str,con))
                {
                    cmd.Parameters.AddWithValue("@rno", rno);
                    cmd.Parameters.AddWithValue("@studname", studname);
                    cmd.ExecuteNonQuery ();
                    con.Close();
                    return " record deleted sucessfully";
                }

            }
        }
    }
}
