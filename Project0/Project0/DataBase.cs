using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Project0.Domain
{
    class DataBase
    {

        String str = "Data source =DESKTOP-8GSG83E\\SQLSERVER123; initial Catalog =myProject0; integrated security = true";
        
        public void getProductFromDB(string querystring)
        {
            
            SqlConnection conn = new SqlConnection(str);
            ;
            conn.Open();
            SqlCommand cmd = new SqlCommand(querystring, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Store> sl = new List<Store>();
            Store b = new Store();
            
            while (dr.Read())
            {
                Console.WriteLine("\nCurrent Items in DataBase:");
                Console.WriteLine("------------------------------------");
                Console.WriteLine(dr[0].ToString() + " " + dr[1].ToString() + " " + dr[2].ToString());
                b.ID = Convert.ToInt32(dr[0].ToString());
                b.Name = dr[1].ToString();
                b.Price = Convert.ToDecimal(dr[2].ToString());

               
            }
            sl.Add(b);

            conn.Close();

            

        }
    
        public void insertDataIntoDB(string cmdText)
        {
            using (SqlConnection con = new SqlConnection(str))
                try
            {

                
                {

                    SqlCommand cmd1 = new SqlCommand(cmdText, con);
                    con.Open();
                    int row = cmd1.ExecuteNonQuery();
                    Console.WriteLine("\nYou Have Inserted One Row in Your DataBase");
                    Console.WriteLine(row);
                    //cmd1.CommandText = "update Product set product_ID -'rowName' where columnName = 'value'";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPS something went wrong" + e);

                    con.Close();
            }

            
        }

    }
}

