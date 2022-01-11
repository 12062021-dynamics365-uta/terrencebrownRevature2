using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class InStockProduct
    {
        public int product_id { get; set; }
        public string product_Name { get; set; }
        public string location_City { get; set; }
        public decimal product_Price { get; set; }

        public InStockProduct()
        {

        } 
        public InStockProduct(int product_id, string product_Name, string location_City, decimal product_Price)
        {
            this.product_id = product_id;
            this.product_Name = product_Name;
            this.location_City = location_City;
            this.product_Price = product_Price;
        }
        public InStockProduct(int product_id, string product_Name, decimal product_Price)
        {

        }

    }
}
