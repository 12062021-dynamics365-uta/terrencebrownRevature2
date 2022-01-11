using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Order
    {
        public int order_id { get; set; }
        public int product_id { get; set; } 
        public string location_City { get; set; } 
        public string product_Name { get; set; }
        public decimal product_Price { get; set; }
        public string customer_Fname { get; set; }

        public Order()
        {

        }

        public Order(int order_id, int product_id, string location_City, string product_Name, decimal product_Price, string customer_Fname)
        {
            this.order_id = order_id;
            this.product_id = product_id;
            this.location_City = location_City;
            this.product_Name = product_Name;
            this.product_Price = product_Price;
            this.customer_Fname = customer_Fname;
        }
        public Order(int product_id, string product_Name, decimal product_Price)
        {

        }

    }
}
