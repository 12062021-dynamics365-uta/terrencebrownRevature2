using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SweetnSaltyDbAccess
{
    public class SweetnSaltyDbAccessClass : ISweetnSaltyDbAccessClass
    {
        private readonly string str = "Data Source = DESKTOP-8GSG83E\\SQLSERVER123; initial Catalog=SweetnSalty; integrated security = true";/*connection string here.*/
        private readonly SqlConnection _con;

        //constructor
        public SweetnSaltyDbAccessClass()
        {
            this._con = new SqlConnection(this.str);
            _con.Open();
        }
        public async Task<SqlDataReader> PostFlavor(string flavortype)
        {
            
            string querystring = $"INSERT INTO Flavor VALUES (@flavortype)";
            
            using (SqlCommand cmd = new SqlCommand(querystring, this._con))
            {
                cmd.Parameters.AddWithValue("@flavortype", flavortype);

                try
                {
                    await cmd.ExecuteNonQueryAsync();

                    string retrieveFlavor = "SELECT TOP 1 * FROM Flavor ORDER BY productid DESC;";
                    using (SqlCommand cmd1 = new SqlCommand(retrieveFlavor, this._con))
                    {
                       SqlDataReader dr =  await cmd1.ExecuteReaderAsync();

                        return dr;
                    }
                }
                catch (DbException ex)
                {
                    Console.WriteLine($"There was an exception in SweetnSaltyBusinessClass.PostFlavor {ex}");
                    return null;
                }

                
            }
        }

    }

}

