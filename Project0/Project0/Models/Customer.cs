using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Customer
    {
        public int customer_id { get; set; }
        public string customer_Fname { get; set; }

        public string customer_Lname { get; set; }

        public string customer_Email { get; set; }


        public Customer()
        {

        }
        public Customer(string Fname, string Lname, string Email)
        {

        }
        public Customer(int customer_id, string customer_Fname, string customer_Last, string customer_Email)
        {
            this.customer_id = customer_id;
            this.customer_Fname = customer_Fname;
            this.customer_Lname = customer_Lname;
            this.customer_Email = customer_Email;

        }


    }
}
