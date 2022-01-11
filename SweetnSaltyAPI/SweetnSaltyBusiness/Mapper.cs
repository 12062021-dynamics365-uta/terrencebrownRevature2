using SweetnSaltyModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetnSaltyBusiness
{
     public class Mapper : IMapper
    {
       

        public Flavor EntityToFlavor(SqlDataReader dr)
        {
            return new Flavor()
            {
                productid = dr.GetInt32(0),
                flavortype = dr[1].ToString(),

            };
        }

        public Person EntityToPerson(SqlDataReader dr)
        {
            throw new NotImplementedException();
        }
    }
}
