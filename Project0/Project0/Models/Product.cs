using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models

{
    public class Product
    {

        public int _id { get; set; }
        public string _item { get; set; }
        public decimal _price { get; set; }

        List<string> myProductList = new List<string>();


        public Product()
        {

        }
        public Product (int _id, string _item, decimal _price)
        {
            this._id = _id;
            this._item = _item;
            this._price = _price;
           

        }

        public int getID()
        {
            return _id;
        }
        public void setID(int _ID)
        {
            this._id =_ID;
        }
        public string getItem()
        {
            return _item;
        }
        public void setItem(string _item)
        {
            this._item = _item;
        }
        public decimal getPrice()
        {
            return _price;
        }
        public void setPrice(decimal _price)
        {
            this._price = _price;

        }
      




    }
    

}
