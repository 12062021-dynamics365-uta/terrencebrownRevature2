using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Project0.Domain
{
    class ShoppingCart : Product
    {
        public string selectedProduct;
        private string Fname;
        private string Lname;
        private string history;
        Dictionary<string, string> purchaser = new Dictionary<string, string>();

        public ShoppingCart(string Fname, string Lname)
        {
            this.Fname = Fname;
            this.Lname = Lname;

        }
        public ShoppingCart()
        {

        }
        public ShoppingCart(string Fname, string Lname, string selectedProduct)
        {

        }

        public void setFname(string Fname)
        {

            this.Fname = Fname;

        }

        public string getFname(string Fname)
        {

            return Fname;
        }
        public void setLname(string Lname)
        {
            this.Lname = Lname;
            
        }
        public string getLname()
        {

            return Lname;
        }
        
        public void saveUserData(string Fname, string Lname)
        {
            purchaser.Add("Terrence", "Pitts");
            purchaser.Add(Fname, Lname);


        }
        public void itemUserSelected(string Fname, string Lname, string selectedProduct)
        {

            Console.WriteLine(Fname + Lname);
            
            Console.WriteLine("\nYou selected this product  " + selectedProduct);
        }
        
        public void updateUserCheck() { 

            for(int index = 0; index < purchaser.Count; index++)
            {
                var itemNames = purchaser.ElementAt(index);
                var itemKeys = itemNames.Key;
                var itemValue = itemNames.Value;

                Console.WriteLine("\nYour Name is: " + itemKeys + " " + itemValue);
            }
    

         }
        public void getHistory(string Fname, string Lname)
        {
            Console.WriteLine("Here is your shopping history: " + Fname + " " + Lname);

        }
        public void checkName(string Fname, string Lname)
        {

            foreach (KeyValuePair<string, string> kvp in purchaser)
            {
                Console.WriteLine("\n" + "FirstName = {0} LastName = {1}", kvp.Key, kvp.Value);





                if (purchaser.ContainsKey(kvp.Key))
                {
                    Console.WriteLine("\nYour name is saved in our the System: " + kvp.Key + " " + kvp.Value);
                }
                else if (!purchaser.ContainsKey(kvp.Key))
                {
                    Console.WriteLine("Your {0}, {1},  is not in the System", kvp.Key, kvp.Value);

                }
            }
  


        } 
         
    } 
}

    

