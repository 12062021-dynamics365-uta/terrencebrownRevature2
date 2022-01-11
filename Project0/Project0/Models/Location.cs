using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


    namespace Models


    {
    public class Location
    {
        public int location_id {get;set; }
        public string location_City { get; set; }
        public string location_State { get; set; }

        List<string> myLocation = new List<string>();

        public Location()
        {

        }
        public Location (int location_id, string location_City, string location_State)
        {
            this.location_id = location_id;
            this.location_City = location_City;
            this.location_State = location_State;
        }

          

        }
    }