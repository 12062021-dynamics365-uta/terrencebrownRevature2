using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models


{
    public class Store
    {
        public int ID { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        private string Name = "BuyNows";

        public Store()
        {

        }
        public Store(int ID, string City, string State)
        {
            this.ID = ID;
            this.City = City;
            this.State = State;
        }

        public string  getName()
        {
            return Name;
        }

        




      

        
        
        
    }
}
