using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Models
{
    public class Mapping : IMapper
    {
        public List<Product> mapDataBaseProduct(SqlDataReader dr)
        {
            List<Product> products = new List<Product>();
            while (dr.Read())
            {


                Console.WriteLine("Here are BuyNows Products");
               // Console.WriteLine(dr[0].ToString() + " " + dr[1].ToString() + " " + dr[2].ToString());
                Product p = new Product()
                {

                    _id = Convert.ToInt32(dr[0].ToString()),
                    _item = dr[1].ToString(),
                    _price = Convert.ToDecimal(dr[2].ToString()),
                   
                   

                };
               
                products.Add(p);

            }
            return products;
        }
    }
}
    
