using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


    namespace Project0
    {
        class Location
        {
            private string _locationCity = "Greenville";
            private string _locationCity2 = "Anderson";
            private string _locationCity3 = "Spartanburg";
            private string _locationState = "South Carolina";
            private string _storeName = "BuyNow";
            public List<string> myList = new List<string> { "Anderson" };

            public void setLocationCity(string _locationCity)
            {
                this._locationCity = _locationCity;


            }
            public string getLocationCity()
            {
                return _locationCity;
            }
            public void setLocationCity2(string _locationCity2)
            {
                this._locationCity2 = _locationCity2;
            }
            public string getLocationCity2()
            {
                return _locationCity2;
            }
            public void setLocationCity3(string _locationCity3)
            {
                this._locationCity3 = _locationCity3;
            }
            public string getLocationCity3()
            {
                return _locationCity3;
            }
            public string getLocationState()
            {
                return _locationState;
            }
            public string getStoreName()
            {
                return _storeName;
            }

        }
    }