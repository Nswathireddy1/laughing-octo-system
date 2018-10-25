using System;
using System.Data.SqlClient;

namespace AdoNetConsoleApplication
{
    class SelfInsert
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database=student; integrated security=SSPI");

                SqlCommand cm = new SqlCommand("insert into SelfJoinCreate(id,name,age,address,salary)values('111','naresh','23','TPT','25000')", con);
                SqlCommand cm1 = new SqlCommand("insert into SelfJoinCreate(id,name,age,address,salary)values('112','mahesh','23','TPT','35000')", con);
                SqlCommand cm2 = new SqlCommand("insert into SelfJoinCreate(id,name,age,address,salary)values('113','anjali','23','TPT','15000')", con);
                SqlCommand cm3 = new SqlCommand("insert into SelfJoinCreate(id,name,age,address,salary)values('114','vanaja','23','TPT','20000')", con);
                SqlCommand cm4 = new SqlCommand("insert into SelfJoinCreate(id,name,age,address,salary)values('115','chandu','23','TPT','45000')", con);
                SqlCommand cm5 = new SqlCommand("insert into SelfJoinCreate(id,name,age,address,salary)values('116','subhu','23','TPT','37000')", con);

                con.Open();
              //  cm.ExecuteNonQuery();
              //  cm1.ExecuteNonQuery();
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
