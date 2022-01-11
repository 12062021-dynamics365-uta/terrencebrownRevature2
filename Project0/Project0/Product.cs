using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0.Domain
{
    class Product : Location
    {
        
        private string _item;
        private int _ID;
        private double _price;
        List<string> myProductList;


        public Product()
        {

        }
        public Product (int _ID, string _item, double _price)
        {
           

        }

        public int getID()
        {
            return _ID;
        }
        public void setID(int _ID)
        {
            this._ID =_ID;
        }
        public string getItem()
        {
            return _item;
        }
        public void setItem(string _item)
        {
            this._item = _item;
        }
        public double getPrice()
        {
            return _price;
        }
        public void setPrice(double _price)
        {
            this._price = _price;

        }
      




    }
    

}
