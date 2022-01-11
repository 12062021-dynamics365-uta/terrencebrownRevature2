using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Project0.Domain;







    namespace Project0


    { 
    
        class Program
        {
            static void Main(string[] args)
            {
                
                Location mylocation = new Location();
                Console.WriteLine("HELLO and Welcome to BuyNow");
                Console.WriteLine("All " + mylocation.getStoreName() + " locations In " + mylocation.getLocationState());
                Console.WriteLine("--------------------------------------");
                Console.WriteLine(mylocation.getLocationCity() + "\n" + mylocation.getLocationCity2() + "\n" + mylocation.getLocationCity3() + "\n");






                Product myProduct1 = new Product();
                Product myProduct2 = new Product();
                Product myProduct3 = new Product();
                myProduct1.setID(1);
                myProduct1.setItem("dell");
                myProduct1.setPrice(10.73);
                myProduct2.setID(2);
                myProduct2.setItem("hp");
                myProduct2.setPrice(10.62);
                myProduct3.setID(3);
                myProduct3.setItem("Apple");
                myProduct3.setPrice(10.22);




                List<Product> myListProducts = new List<Product>();
                myListProducts.Add(myProduct1);
                myListProducts.Add(myProduct2);
                myListProducts.Add(myProduct3);

                //-----------------------------------------------------------------------------------------------
                string yourLocation;
                do
                {
                    Console.WriteLine("Please type in your Location of choice");
                    yourLocation = Console.ReadLine();




                    if (yourLocation.Equals(mylocation.getLocationCity()))
                    {
                        Console.WriteLine("You have selected: " + mylocation.getLocationCity());

                        Console.WriteLine("Here are the product at BuyNow in " + mylocation.getLocationCity(), mylocation.getLocationState());
                        Console.WriteLine(myProduct1.getID() + " " + myProduct1.getItem() + " " + myProduct1.getPrice());
                        Console.WriteLine(myProduct2.getID() + " " + myProduct2.getItem() + " " + myProduct2.getPrice());
                        Console.WriteLine(myProduct3.getID() + " " + myProduct3.getItem() + " " + myProduct3.getPrice());

                        ShoppingCart myShoppingCart = new ShoppingCart();


                        Console.WriteLine("Please Enter you First Name ");
                        string firstNameSaved = Console.ReadLine();
                        Console.WriteLine("Please Enter you Last Name ");
                        string lastNameSaved = Console.ReadLine();

                        myShoppingCart.checkName(firstNameSaved, lastNameSaved);
                        myShoppingCart.setFname(firstNameSaved);
                        myShoppingCart.setLname(lastNameSaved);
                        myShoppingCart.checkName(firstNameSaved, lastNameSaved);
                        myShoppingCart.saveUserData(firstNameSaved, lastNameSaved);
                        myShoppingCart.updateUserCheck();
                        myShoppingCart.checkName(firstNameSaved, lastNameSaved);

                        string itemSelection;
                        do
                        {
                            Console.WriteLine("\nPlease write the item name from the list above: ");
                            itemSelection = Console.ReadLine();

                            if (itemSelection.Equals(myProduct1.getItem()))
                            {
                                Console.WriteLine("\nYour order is complete. You have selected the {0}", myProduct1.getItem());
                                Console.WriteLine("\nCheckout");
                                Console.WriteLine("-----------------------");
                                myShoppingCart.itemUserSelected(firstNameSaved, lastNameSaved, myProduct1.getItem());
                                Console.WriteLine("\nYour balance is {0} ", myProduct1.getPrice());
                                break;


                            }
                            else if (itemSelection.Equals(myProduct2.getItem()))
                            {
                                Console.Write(" You order is complete. You have seleced the {0} " + myProduct2);
                                Console.WriteLine("\nCheckout");
                                Console.WriteLine("-----------------------");
                                myShoppingCart.itemUserSelected(firstNameSaved, lastNameSaved, myProduct2.getItem());
                                Console.WriteLine("\nYour balance is {0} ", myProduct2.getPrice());
                                break;
                            }
                            else if (itemSelection.Equals(myProduct3.getItem()))
                            {
                                Console.WriteLine("Your order is complete. You have selected the {0} " + myProduct3);
                                Console.WriteLine("\nCheckout");
                                Console.WriteLine("-----------------------");
                                myShoppingCart.itemUserSelected(firstNameSaved, lastNameSaved, myProduct3.getItem());
                                Console.WriteLine("\nYour balance is {0} ", myProduct3.getPrice());
                                break;
                            }
                            else
                            {
                                Console.WriteLine("This item is not in our system.");
                            }
                        } while (!itemSelection.Equals(myProduct1.getItem()) || itemSelection.Equals(myProduct2.getItem()) || itemSelection.Equals(myProduct3.getItem()));






                        break;

                    }
                    else if (yourLocation.Equals(mylocation.getLocationCity2()))
                    {
                        Console.WriteLine("You have selected: " + mylocation.getLocationCity2());

                        Console.WriteLine("Here are the product at BuyNow in " + mylocation.getLocationCity2(), mylocation.getLocationState());
                        Console.WriteLine(myProduct1.getID() + " " + myProduct1.getItem() + " " + myProduct1.getPrice());
                        Console.WriteLine(myProduct2.getID() + " " + myProduct2.getItem() + " " + myProduct2.getPrice());
                        Console.WriteLine(myProduct3.getID() + " " + myProduct3.getItem() + " " + myProduct3.getPrice());
                        break;
                    }
                    else if (yourLocation.Equals(mylocation.getLocationCity3()))
                    {
                        Console.WriteLine("You have selected: " + mylocation.getLocationCity3());

                        Console.WriteLine("Here are the product at BuyNow in " + mylocation.getLocationCity3(), mylocation.getLocationState());
                        Console.WriteLine(myProduct1.getID() + " " + myProduct1.getItem() + " " + myProduct1.getPrice());
                        Console.WriteLine(myProduct2.getID() + " " + myProduct2.getItem() + " " + myProduct2.getPrice());
                        Console.WriteLine(myProduct3.getID() + " " + myProduct3.getItem() + " " + myProduct3.getPrice());

                        break;
                    }
                } while (!yourLocation.Equals(mylocation.getLocationCity()) || yourLocation.Equals(mylocation.getLocationCity2()) || yourLocation.Equals(mylocation.getLocationCity3()));

                DataBase myDB = new DataBase();
                myDB.getProductFromDB("Select * FROM Products");
                myDB.insertDataIntoDB("Insert INTO Products values(4, 'lemons', 9.25)");


            }
        }
    }

