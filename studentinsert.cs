﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetConsoleApplication
{
    class StudentInsert
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database=student; integrated security=SSPI");

                SqlCommand cm = new SqlCommand("insert into student4(rollNo,name)values('10','swa')", con);
                SqlCommand cm1 = new SqlCommand("insert into student4(rollNo,name,class)values('11','mahi','10')", con);
                SqlCommand cm2 = new SqlCommand("insert into student4(rollNo,name)values('12','ram')", con);
                SqlCommand cm3 = new SqlCommand("insert into student4(rollNo,name)values('13','pra')", con);
                SqlCommand cm4 = new SqlCommand("insert into student4(rollNo,name,class)values('14','chandu','12')", con);
                SqlCommand cm5 = new SqlCommand("insert into student4(rollNo,name,class)values('15','subhu','14')", con);


                //   SqlCommand cm6 = new SqlCommand("insert into studentIInfo(rollNo,class)values('117','10')", con);
                con.Open();

                cm.ExecuteNonQuery();
                cm1.ExecuteNonQuery();
                cm2.ExecuteNonQuery();
                cm3.ExecuteNonQuery();
                cm4.ExecuteNonQuery();
                cm5.ExecuteNonQuery();

                Console.WriteLine("Record Inserted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
