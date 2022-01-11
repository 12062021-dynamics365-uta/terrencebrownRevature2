using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace Models
{
  public interface IMapper
    {
        public List<Product> mapDataBaseProduct(SqlDataReader dr);
    }
}
