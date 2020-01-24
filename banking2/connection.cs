using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace banking2
{
    public class connection
    {

        //public static Boolean create = false;
        public static string accno;
        public static string user = "";
        public static string acc_acOp;//for the accounting operations form form
        public static Boolean ifadmin = false;
        
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Navnit Kumar\\source\\repos\\banking2\\banking2\\bankingDB.mdf;Integrated Security=True");

        public static string accCreation()
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < 11; i++)
                s = String.Concat(s, random.Next(10).ToString());
            return s;
            
        }
        public static float random(int num)
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < num; i++)
                s = String.Concat(s, random.Next(10).ToString());
            return float.Parse(s);

        }
        public string checkAc()
        {

            using (this.con)
            {
                string ac = connection.accCreation();
                this.con.Open();
                string acc = "";
                SqlDataAdapter sda = new SqlDataAdapter("select *from Customer where ac_no=@acno", this.con);
                sda.SelectCommand.Parameters.AddWithValue("@acno", ac);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    while (dtbl.Rows.Count == 1)
                    {
                        dtbl.Clear();
                        acc = accCreation();
                        SqlDataAdapter sda1 = new SqlDataAdapter("select *from Customer where ac_no=@acno", this.con);
                        sda1.SelectCommand.Parameters.AddWithValue("@acno", acc);
                        sda1.Fill(dtbl);
                    }
                    return acc;
                }
                else
                {
                    return ac;
                }
            }
        }
        public float randomBal()
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Navnit Kumar\\source\\repos\\banking2\\banking2\\bankingDB.mdf;Integrated Security=True");

            using (conn)
             {
                float num = random(5);
                conn.Open();
                 float temp=0 ;
                 SqlDataAdapter sda = new SqlDataAdapter("select *from TRANS_ACTION where bal=@acno", conn);
                 sda.SelectCommand.Parameters.AddWithValue("@acno", num);
                 DataTable dtbl = new DataTable();
                 sda.Fill(dtbl);
                 if (dtbl.Rows.Count >= 1)
                     {
                 while (dtbl.Rows.Count >= 1)
                 {
                    dtbl.Clear();
                    temp = random(5);
                    SqlDataAdapter sda1 = new SqlDataAdapter("select *from TRANS_ACTION where bal=@acno", conn);
                        sda1.SelectCommand.Parameters.AddWithValue("@acno", temp);
                    sda1.Fill(dtbl);
                }
                return temp;
                 }
                    else
                    {
                        return num;
                    }
             }
        }
    }
   
}
