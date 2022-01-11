using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using Models;


namespace Storage

{
    public class DataBase
    {
        string str1 = "Data source =DESKTOP-8GSG83E\\SQLSERVER123; initial Catalog =myProject0; integrated security = true";
        private readonly string str = "Data source =DESKTOP-8GSG83E\\SQLSERVER123; initial Catalog =myProject0; integrated security = true";
        private readonly SqlConnection _conn;
        Store mystore = new Store();
        public List<Store> sl = new List<Store>();
        Store b = new Store();
        public Product convertProduct = new Product();
        private readonly Mapping _mapper;
        public List<Product> products = new List<Product>();
        public List<Customer> myCustomers = new List<Customer>();
        public List<Location> myLocat = new List<Location>();

        public DataBase()
        {

        }

        public DataBase(Mapping mapper)
        {
            this._conn = new SqlConnection(this.str);
            this._mapper = mapper;
        }
        public DataBase(string Fname, string Lname, string Email)
        {

        }
        public DataBase(int product_id, string product_Name, string customer_Fname, decimal product_Price, string location_City)
        {

        }

        //retieves data from DataBase. The data is transition into a List
        public List<Product> getProductFromDB()
        {
            string querystring = ("Select * From Products");
            //products = new List<Product>();
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand cmd = new SqlCommand(querystring, conn);

            //conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            products = this._mapper.mapDataBaseProduct(dr);

            foreach (var p in products)
            {
                Console.WriteLine(p._id + " " + p._item + " " + p._price);


                if (p._id == 1)
                {
                    Console.WriteLine($"Found product id {p._id}: ");
                }
            } return products;
        }
        public void userCurrentFrom()
        {
            foreach (var p in products)
            {
                Console.WriteLine(p._id + " " + p._item + " " + p._price);


                if (p._item == "hp")
                {
                    Console.WriteLine($"Found product id {p._item}: ");
                }
            }
        }










        public List<Location> getLocationFromDB()
        {

            SqlConnection conn = new SqlConnection(str1);
            string querystring = ("Select * FROM Location");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand(querystring, conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            //products = this.mapper.mapUserToObject(dr);
            List<Location> myLocat = new List<Location>();



            Location l;
            Console.WriteLine("\nHere is BuyNows Locations");
            Console.WriteLine("------------------------------------");
            while (dr1.Read())
            {

                l = new Location()
                {
                    location_id = Convert.ToInt32(dr1[0].ToString()),
                    location_City = dr1[1].ToString(),
                    location_State = dr1[2].ToString(),
                };
                myLocat.Add(l);
            }

            foreach (var loc in myLocat)
            {
                Console.WriteLine(loc.location_id + " " + loc.location_City + " " + loc.location_State);


            }
            return myLocat;

        }

        public List<Customer> getUsersFromDB()
        {
            SqlConnection conn = new SqlConnection(str);
            string querystring = ("Select * FROM Customers");
            conn.Open();
            SqlCommand cmd = new SqlCommand(querystring, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Customer> myCustomers = new List<Customer>();
            Customer c;

            Console.WriteLine("Current Customers in BuyNows Systems");
            Console.WriteLine("----------------------------------------");
            while (dr.Read())
            {
                c = new Customer();
                c.customer_Fname = dr[0].ToString();
                c.customer_Lname = dr[1].ToString();
                c.customer_Email = dr[2].ToString();

                myCustomers.Add(c);
                Console.WriteLine(c.customer_Fname + c.customer_Lname);
            }
            conn.Close();

            return myCustomers;
        }

        public void saveUserDataToDB(string Fname, string Lname, string Email)
        {
            List<string> myCustomer1 = new List<string>();
            Customer c3 = new Customer();

            myCustomer1.Add(Fname);
            myCustomer1.Add(Lname);
            myCustomer1.Add(Email);

            SqlConnection conn = new SqlConnection(str1);
            string querystring = ("INSERT INTO Customers (customer_Fname, customer_Lname,customer_Email) VALUES (@customer_Fname,@customer_Lname,@customer_Email)");
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(querystring, conn))
            {
                cmd.Parameters.Add("@customer_Fname", sqlDbType: System.Data.SqlDbType.VarChar).Value = Fname;
                cmd.Parameters.Add("@customer_Lname", sqlDbType: System.Data.SqlDbType.VarChar).Value = Lname;
                cmd.Parameters.Add("@customer_Email", sqlDbType: System.Data.SqlDbType.VarChar).Value = Email;

                SqlDataReader dr = cmd.ExecuteReader();
            };


            conn.Close();
        }


        public List<InStockProduct> getLocationAndProductForUser()
        {
            SqlConnection conn = new SqlConnection(str1);
            string querystring = ("Select p.product_Name, p.product_id, loc.location_City,p.product_Price From Products p Left Join InStockProduct sp on sp.product_id = p.product_id Left Join Location loc on loc.location_id = sp.location_id where loc.location_City = 'Greenville' ");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand(querystring, conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            //products = this.mapper.mapUserToObject(dr);
            List<InStockProduct> inStock = new List<InStockProduct>() ;
            InStockProduct isp;

            while (dr1.Read())
            {

                isp = new InStockProduct();


                isp.product_id = Convert.ToInt32(dr1[1].ToString());
                isp.product_Name = dr1[0].ToString();
                isp.location_City = dr1[2].ToString();
                isp.product_Price = Convert.ToDecimal(dr1[3].ToString());

                Console.WriteLine(isp.product_id + " " + isp.product_Name + " " + isp.location_City + " " + isp.product_Price);


                inStock.Add(isp);
            };
                
               
                    
        
            
            return inStock;
        }
        public List<InStockProduct> getLocationAndProductForUserInAnderson()
        {
            SqlConnection conn = new SqlConnection(str1);
            string querystring = ("Select p.product_Name, p.product_id, loc.location_City,p.product_Price From Products p Left Join InStockProduct sp on sp.product_id = p.product_id Left Join Location loc on loc.location_id = sp.location_id where loc.location_City = 'Anderson' ");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand(querystring, conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            //products = this.mapper.mapUserToObject(dr);
            List<InStockProduct> inStock = new List<InStockProduct>();
            InStockProduct isp;

            while (dr1.Read())
            {

                isp = new InStockProduct();


                isp.product_id = Convert.ToInt32(dr1[1].ToString());
                isp.product_Name = dr1[0].ToString();
                isp.location_City = dr1[2].ToString();
                isp.product_Price = Convert.ToDecimal(dr1[3].ToString());

                Console.WriteLine(isp.product_id + " " + isp.product_Name + " " + isp.location_City + " " + isp.product_Price);


                inStock.Add(isp);
            };





            return inStock;
        }
        public List<InStockProduct> getLocationAndProductForUserInSpartanburg()
        {
            SqlConnection conn = new SqlConnection(str1);
            string querystring = ("Select p.product_Name, p.product_id, loc.location_City,p.product_Price From Products p Left Join InStockProduct sp on sp.product_id = p.product_id Left Join Location loc on loc.location_id = sp.location_id where loc.location_City = 'Spartanburg' ");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand(querystring, conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            //products = this.mapper.mapUserToObject(dr);
            List<InStockProduct> inStock = new List<InStockProduct>();
            InStockProduct isp;

            while (dr1.Read())
            {

                isp = new InStockProduct();


                isp.product_id = Convert.ToInt32(dr1[1].ToString());
                isp.product_Name = dr1[0].ToString();
                isp.location_City = dr1[2].ToString();
                isp.product_Price = Convert.ToDecimal(dr1[3].ToString());

                Console.WriteLine(isp.product_id + " " + isp.product_Name + " " + isp.location_City + " " + isp.product_Price);


                inStock.Add(isp);
            };





            return inStock;
        }

        public void userCheckOut( int product_id, string product_Name, string customer_Fname, decimal product_Price, string location_City )
        {
            List<Order> customerOrder = new List<Order>();
            Order myOrder = new Order();
            

            myOrder.product_id = product_id;
            myOrder.product_Name = product_Name;
            myOrder.customer_Fname = customer_Fname;
            myOrder.product_Price = product_Price;
            myOrder.location_City = location_City;
         


            SqlConnection conn = new SqlConnection(str1);
            string querystring = ("INSERT INTO Orders (product_id, product_Name,customer_Fname,product_Price,location_City) VALUES (@product_id, @product_Name,@customer_Fname,@product_Price,@location_City)");
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(querystring, conn))
            {
                cmd.Parameters.Add("@product_id", sqlDbType: System.Data.SqlDbType.Int).Value = product_id;
                cmd.Parameters.Add("@product_Name", sqlDbType: System.Data.SqlDbType.VarChar).Value = product_Name;
                cmd.Parameters.Add("@customer_Fname", sqlDbType: System.Data.SqlDbType.VarChar).Value = customer_Fname;
                cmd.Parameters.Add("@product_Price", sqlDbType: System.Data.SqlDbType.Decimal).Value = product_Price;
                cmd.Parameters.Add("@location_City", sqlDbType: System.Data.SqlDbType.VarChar).Value = location_City;

                SqlDataReader dr = cmd.ExecuteReader();
            };


            conn.Close();
        }


    }

}
    
