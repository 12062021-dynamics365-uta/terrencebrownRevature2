using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Storage;
using System.Text.RegularExpressions;


namespace Domain
{
    public class Selection
    {

        public int selectionNum1 = 1;
        public int selectionNum2 = 2;
        public int selectionNum3 = 3;
        DataBase myCus = new DataBase();
        List<Customer> customerName = new List<Customer>();
        Customer c1 = new Customer();
        bool isNumber;
        int numericValue;



        public void userSelectionNumber()
        {
            string firstLine;
            do
            {
                Console.WriteLine("HELLO and Welcome to BuyNow");
                Console.WriteLine("How can we help you?");
                Console.WriteLine("Please Select the Option by Number");
                Console.WriteLine("1 = Login " + "2 = Register");
                Console.WriteLine("--------------------------------------");
                firstLine = Console.ReadLine();

                if (Convert.ToInt32(firstLine).Equals(1))
                {


                    Console.WriteLine("Please enter your First Name");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Please enter your Last Name");
                    string lastName = Console.ReadLine();
                    List<Customer> c = myCus.getUsersFromDB();
                    //Customer c5 = new Customer();
                   /* foreach (Customer c5 in c)
                    {
                        Console.WriteLine(c5);
                    }
                    Console.WriteLine(customerName);
                    Console.WriteLine(c[0].customer_Fname + "  " + c[1].customer_Lname);*/


                    
                    if (!firstName.Equals(c[0].customer_Fname))
                    {
                        Console.WriteLine("You are a current user");
                        Console.WriteLine($"You are login in as {c[0].customer_Fname }");

                        c1.customer_Fname = c[0].customer_Fname;
                        //Ac1.customer_Lname = c[2].customer_Lname;
                        //CurrentUser();

                    }
                    customerName.Add(c1);

                }
                else if (Convert.ToInt32(firstLine).Equals(2))

                {

                    Console.WriteLine("Please enter your First Name");
                    string firstName2 = Console.ReadLine();
                    Console.WriteLine("Please enter your Last Name");
                    string lastName2 = Console.ReadLine();
                    Console.WriteLine("Please enter email Address");
                    string emailAdd = Console.ReadLine();
                    myCus.saveUserDataToDB(firstName2, lastName2, emailAdd);
                    CurrentUser(firstName2);
                    break;

                }
                else
                {
                    Console.WriteLine("You are not a current user");
                }


            } while (!Convert.ToInt32(firstLine).Equals(1) || !Convert.ToInt32(firstLine).Equals(2));
        }
        public List<InStockProduct> CurrentUser(string firstName2)
        {

            Console.WriteLine("Please select a BuyNows Locations");
            Console.WriteLine("Greenville | Anderson | Spartanburg");
            string userLocation = Console.ReadLine();
            List<Location> loc1 = myCus.getLocationFromDB();
            List<InStockProduct> userProductList = new List<InStockProduct>();
            List<InStockProduct> userProductList1 = new List<InStockProduct>();
            List<InStockProduct> userProductList2 = new List<InStockProduct>();
            userProductList.AddRange(userProductList1);
            userProductList.AddRange(userProductList2);
            Customer c3 = new Customer();
            List<Customer> cout = new List<Customer>();
            InStockProduct cout1 = new InStockProduct();
            decimal sum = 0;


            if (userLocation.Equals(loc1[0].location_City))
            {

                Console.WriteLine($"You have select BuyNow in {loc1[0].location_City} ");
                Console.WriteLine("Here Are BuyNows Products");
                List<InStockProduct> inStockGreenville = myCus.getLocationAndProductForUser();

                InStockProduct p2 = new InStockProduct();
                string userProductSelection;

                do
                {

                    Console.WriteLine("Please select your Product by selecting the number key above | 4 for checkout | 5 for Past History");
                    userProductSelection = Console.ReadLine();


                    if (Convert.ToInt32(userProductSelection).Equals(inStockGreenville[0].product_id))
                    {

                        Console.WriteLine($"Your have selected the {inStockGreenville[0].product_id} {inStockGreenville[0].product_Name} {inStockGreenville[0].product_Price} ");

                        p2.product_id = inStockGreenville[0].product_id;
                        p2.product_Name = inStockGreenville[0].product_Name;

                        Console.Write("This is what i printed" + (inStockGreenville[0].product_Price));
                        p2.product_Price = inStockGreenville[0].product_Price;
                        //userProductList.Add(inStockGreenville[0].product_Price);
                        userProductList.Add(p2);
                    }

                    else if (Convert.ToInt32(userProductSelection).Equals(inStockGreenville[1].product_id))
                    {
                        //userProductList.Add(p2);
                        Console.WriteLine($"Your have selected the {inStockGreenville[1].product_id} {inStockGreenville[1].product_Name} {inStockGreenville[1].product_Price}");

                        p2.product_id = inStockGreenville[1].product_id;
                        p2.product_Name = inStockGreenville[1].product_Name;
                        p2.product_Price = inStockGreenville[1].product_Price;
                        userProductList.Add(p2);
                        /* userProductList1 = userProductList.ConvertAll(x => new InStockProduct
                          {
                              p2.product_id = p2.product_id,
                              p2.product_Price = p2.product_Price,
                              p2.product_Name = p2.product_Name
                          });*/
                        //userProductList.AddRange(userProductList1);

                    }

                    else if (Convert.ToInt32(userProductSelection).Equals(inStockGreenville[2].product_id))
                    {
                        Console.WriteLine($"Your have selected the {inStockGreenville[2].product_id} {inStockGreenville[2].product_Name} {inStockGreenville[2].product_Price}");

                        p2.product_id = inStockGreenville[2].product_id;
                        p2.product_Name = inStockGreenville[2].product_Name;
                        p2.product_Price = inStockGreenville[2].product_Price;
                        userProductList.Add(p2);
                        //userProductList.AddRange(userProductList2);
                    }

                    else if (Convert.ToInt32(userProductSelection).Equals(4))
                    {

                        c3.customer_Fname = firstName2;
                        //cout.customer_Fname = c3.customer_Fname;
                        //c3.customer_Fname = customerName[0].customer_Fname;
                        //cout1.customer_Fname = c3.customer_Fname;
                        //userProductList.Add(p2);
                        //userProductList1.ForEach(item => userProductList.Add(p2));

                        foreach (InStockProduct pp in userProductList)
                        {

                            Console.WriteLine(pp.product_Price);
                            cout1.product_id = pp.product_id;
                            // cout1.customer_Fname = c3.customer_Fname;
                            cout1.product_Name = pp.product_Name;
                            cout1.product_Price = pp.product_Price;
                            cout1.location_City = userLocation;
                            // Console.WriteLine(cout1.product_Price);
                            sum += pp.product_Price;
                        }
                       /* foreach (InStockProduct pp1 in userProductList1)
                        {
                            Console.WriteLine("Product 2" + pp1.product_Price);
                            sum += pp1.product_Price;
                        }*/

                        //Console.WriteLine(sum += cout1.product_Price);
                        //sum += cout1.product_Price;
                        myCus.userCheckOut(cout1.product_id, cout1.product_Name, c3.customer_Fname, cout1.product_Price, cout1.location_City);
                        Console.WriteLine($"Here are the Items you have CheckOut at BuyNows in {userLocation.Equals(cout1.location_City)}");
                        Console.WriteLine($"\nThank you {c3.customer_Fname}");
                        Console.WriteLine("-----------------------------------------------------");


                        Console.WriteLine(cout1.product_id + " " + cout1.product_Name + " " + c3.customer_Fname + " " + cout1.product_Price + " " + cout1.location_City);

                        Console.WriteLine("\nHere is your total");
                        Console.WriteLine(sum);
                        break;
                    }



                } while (Convert.ToInt32(userProductSelection).Equals(inStockGreenville[0].product_id) || Convert.ToInt32(userProductSelection).Equals(inStockGreenville[1].product_id) || Convert.ToInt32(userProductSelection).Equals(inStockGreenville[2].product_id) || Convert.ToInt32(userProductSelection).Equals(inStockGreenville[3].product_id));
            }
            if (userLocation.Equals(loc1[1].location_City))
            {
                Console.WriteLine($"You have select BuyNow in {loc1[1].location_City} ");
                Console.WriteLine("Here Are BuyNows Products");
                List<InStockProduct> inStockGreenville = myCus.getLocationAndProductForUserInAnderson();

                InStockProduct p2 = new InStockProduct();
                string userProductSelection;

                do
                {

                    Console.WriteLine("Please select your Product by selecting the number key above | 4 for checkout | 5 for Past History");
                    userProductSelection = Console.ReadLine();


                    if (Convert.ToInt32(userProductSelection).Equals(inStockGreenville[0].product_id))
                    {

                        Console.WriteLine($"Your have selected the {inStockGreenville[0].product_id} {inStockGreenville[0].product_Name} {inStockGreenville[0].product_Price} ");

                        p2.product_id = inStockGreenville[0].product_id;
                        p2.product_Name = inStockGreenville[0].product_Name;

                        Console.Write("This is what i printed" + (inStockGreenville[0].product_Price));
                        p2.product_Price = inStockGreenville[0].product_Price;
                        //userProductList.Add(inStockGreenville[0].product_Price);
                        userProductList.Add(p2);
                    }

                    else if (Convert.ToInt32(userProductSelection).Equals(inStockGreenville[1].product_id))
                    {
                        //userProductList.Add(p2);
                        Console.WriteLine($"Your have selected the {inStockGreenville[1].product_id} {inStockGreenville[1].product_Name} {inStockGreenville[1].product_Price}");

                        p2.product_id = inStockGreenville[1].product_id;
                        p2.product_Name = inStockGreenville[1].product_Name;
                        p2.product_Price = inStockGreenville[1].product_Price;
                        userProductList.Add(p2);
                        /* userProductList1 = userProductList.ConvertAll(x => new InStockProduct
                          {
                              p2.product_id = p2.product_id,
                              p2.product_Price = p2.product_Price,
                              p2.product_Name = p2.product_Name
                          });*/
                        //userProductList.AddRange(userProductList1);

                    }

                    else if (Convert.ToInt32(userProductSelection).Equals(inStockGreenville[2].product_id))
                    {
                        Console.WriteLine($"Your have selected the {inStockGreenville[2].product_id} {inStockGreenville[2].product_Name} {inStockGreenville[2].product_Price}");

                        p2.product_id = inStockGreenville[2].product_id;
                        p2.product_Name = inStockGreenville[2].product_Name;
                        p2.product_Price = inStockGreenville[2].product_Price;
                        userProductList2.Add(p2);
                        userProductList.AddRange(userProductList2);
                    }

                    else if (Convert.ToInt32(userProductSelection).Equals(4))
                    {

                        c3.customer_Fname = firstName2;
                        //cout.customer_Fname = c3.customer_Fname;
                        //c3.customer_Fname = customerName[0].customer_Fname;
                        //cout1.customer_Fname = c3.customer_Fname;
                        //userProductList.Add(p2);
                        //userProductList1.ForEach(item => userProductList.Add(p2));

                        foreach (InStockProduct pp in userProductList)
                        {

                            Console.WriteLine(pp.product_Price);
                            cout1.product_id = pp.product_id;
                            // cout1.customer_Fname = c3.customer_Fname;
                            cout1.product_Name = pp.product_Name;
                            cout1.product_Price = pp.product_Price;
                            cout1.location_City = userLocation;
                            // Console.WriteLine(cout1.product_Price);
                            sum += pp.product_Price;
                        }
                        foreach (InStockProduct pp1 in userProductList1)
                        {
                            Console.WriteLine("Product 2" + pp1.product_Price);
                            sum += pp1.product_Price;
                        }

                        //Console.WriteLine(sum += cout1.product_Price);
                        //sum += cout1.product_Price;
                        myCus.userCheckOut(cout1.product_id, cout1.product_Name, c3.customer_Fname, cout1.product_Price, cout1.location_City);
                        Console.WriteLine($"Here are the Items you have CheckOut at BuyNows in {userLocation.Equals(cout1.location_City)}");
                        Console.WriteLine($"\nThank you {c3.customer_Fname}");
                        Console.WriteLine("-----------------------------------------------------");


                        Console.WriteLine(cout1.product_id + " " + cout1.product_Name + " " + c3.customer_Fname + " " + cout1.product_Price + " " + cout1.location_City);

                        Console.WriteLine("\nHere is your total");
                        Console.WriteLine(sum);
                        break;
                    }

                } while (Convert.ToInt32(userProductSelection).Equals(inStockGreenville[0].product_id) || Convert.ToInt32(userProductSelection).Equals(inStockGreenville[1].product_id) || Convert.ToInt32(userProductSelection).Equals(inStockGreenville[2].product_id) || Convert.ToInt32(userProductSelection).Equals(inStockGreenville[3].product_id));




            }
            if (userLocation.Equals(loc1[2].location_City))
            {
                Console.WriteLine($"You have select BuyNow in {loc1[2].location_City} ");
                Console.WriteLine("Here Are BuyNows Products");
                List<InStockProduct> inStockGreenville = myCus.getLocationAndProductForUserInSpartanburg();

                InStockProduct p2 = new InStockProduct();
                string userProductSelection;

                do
                {

                    Console.WriteLine("Please select your Product by selecting the number key above | 4 for checkout | 5 for Past History");
                    userProductSelection = Console.ReadLine();


                    if (Convert.ToInt32(userProductSelection).Equals(inStockGreenville[0].product_id))
                    {

                        Console.WriteLine($"Your have selected the {inStockGreenville[0].product_id} {inStockGreenville[0].product_Name} {inStockGreenville[0].product_Price} ");

                        p2.product_id = inStockGreenville[0].product_id;
                        p2.product_Name = inStockGreenville[0].product_Name;

                        Console.Write("This is what i printed" + (inStockGreenville[0].product_Price));
                        p2.product_Price = inStockGreenville[0].product_Price;
                        //userProductList.Add(inStockGreenville[0].product_Price);
                        userProductList.Add(p2);
                    }

                    else if (Convert.ToInt32(userProductSelection).Equals(inStockGreenville[1].product_id))
                    {
                        //userProductList.Add(p2);
                        Console.WriteLine($"Your have selected the {inStockGreenville[1].product_id} {inStockGreenville[1].product_Name} {inStockGreenville[1].product_Price}");

                        p2.product_id = inStockGreenville[1].product_id;
                        p2.product_Name = inStockGreenville[1].product_Name;
                        p2.product_Price = inStockGreenville[1].product_Price;
                        userProductList.Add(p2);
                        /* userProductList1 = userProductList.ConvertAll(x => new InStockProduct
                          {
                              p2.product_id = p2.product_id,
                              p2.product_Price = p2.product_Price,
                              p2.product_Name = p2.product_Name
                          });*/
                        //userProductList.AddRange(userProductList1);

                    }

                    else if (Convert.ToInt32(userProductSelection).Equals(inStockGreenville[2].product_id))
                    {
                        Console.WriteLine($"Your have selected the {inStockGreenville[2].product_id} {inStockGreenville[2].product_Name} {inStockGreenville[2].product_Price}");

                        p2.product_id = inStockGreenville[2].product_id;
                        p2.product_Name = inStockGreenville[2].product_Name;
                        p2.product_Price = inStockGreenville[2].product_Price;
                        userProductList.Add(p2);
                        //userProductList.AddRange(userProductList2);
                    }

                    else if (Convert.ToInt32(userProductSelection).Equals(4))
                    {

                        c3.customer_Fname = firstName2;
                        //cout.customer_Fname = c3.customer_Fname;
                        //c3.customer_Fname = customerName[0].customer_Fname;
                        //cout1.customer_Fname = c3.customer_Fname;
                        //userProductList.Add(p2);
                        //userProductList1.ForEach(item => userProductList.Add(p2));

                        foreach (InStockProduct pp in userProductList)
                        {

                            Console.WriteLine(pp.product_Price);
                            cout1.product_id = pp.product_id;
                            // cout1.customer_Fname = c3.customer_Fname;
                            cout1.product_Name = pp.product_Name;
                            cout1.product_Price = pp.product_Price;
                            cout1.location_City = userLocation;
                            // Console.WriteLine(cout1.product_Price);
                            sum += pp.product_Price;
                        }
                    /*    foreach (InStockProduct pp1 in userProductList1)
                        {
                            Console.WriteLine("Product 2" + pp1.product_Price);
                            sum += pp1.product_Price;
                        }*/

                        //Console.WriteLine(sum += cout1.product_Price);
                        //sum += cout1.product_Price;
                        myCus.userCheckOut(cout1.product_id, cout1.product_Name, c3.customer_Fname, cout1.product_Price, cout1.location_City);
                        Console.WriteLine($"Here are the Items you have CheckOut at BuyNows in {userLocation.Equals(cout1.location_City)}");
                        Console.WriteLine($"\nThank you {c3.customer_Fname}");
                        Console.WriteLine("-----------------------------------------------------");


                        Console.WriteLine(cout1.product_id + " " + cout1.product_Name + " " + c3.customer_Fname + " " + cout1.product_Price + " " + cout1.location_City);

                        Console.WriteLine("\nHere is your total");
                        Console.WriteLine(sum);
                        break;
                    }

                } while (Convert.ToInt32(userProductSelection).Equals(inStockGreenville[0].product_id) || Convert.ToInt32(userProductSelection).Equals(inStockGreenville[1].product_id) || Convert.ToInt32(userProductSelection).Equals(inStockGreenville[2].product_id) || Convert.ToInt32(userProductSelection).Equals(inStockGreenville[3].product_id));
            }
            return userProductList;
        }
    }
}

