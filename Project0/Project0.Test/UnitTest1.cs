using System;
using System.Collections.Generic;
using Xunit;

namespace Project0.Test
{
    public class UnitTest1
    {
        //Test the itemUserSelected method to ensure the first name is returned
        [Fact]
        public void Test1()
        {
            MockData userMockData = new MockData();
            Models.ShoppingCart userTest = new Models.ShoppingCart();

            userTest.itemUserSelected(userMockData.Fname, userMockData.Lname, userMockData.selectedProduct);

            Assert.Equal("Tony", userMockData.Fname);

        }

        //Test the itemUserSelected method to ensure the Last name is returned
        [Fact]
        public void Test2()
        {
            MockData userMockData = new MockData();
            Models.ShoppingCart userTest = new Models.ShoppingCart();

            userTest.itemUserSelected(userMockData.Fname, userMockData.Lname, userMockData.selectedProduct);

            Assert.Equal("Linston", userMockData.Lname);
        }

        //Test the itemUserSelected method to ensure the selected Product is returned
        [Fact]
        public void Test3()
        {
            MockData userMockData = new MockData();
            Models.ShoppingCart userTest = new Models.ShoppingCart();

            userTest.itemUserSelected(userMockData.Fname, userMockData.Lname, userMockData.selectedProduct);

            Assert.Equal("CellPhone", userMockData.selectedProduct);
        }

        //Test the checkName function to ensure the correct first name is saved in the system
        [Fact]
        public void Test4()
        {
            MockData userMockData = new MockData();
            Models.ShoppingCart userTest = new Models.ShoppingCart();

            userTest.checkName(userMockData.Fname, userMockData.Lname);

            Assert.Equal("Tony", userMockData.Fname);
        }
        //Test the checkName function to ensure the correct Last name is saved in the system
        [Fact]
        public void Test5()
        {
            MockData userMockData = new MockData();
            Models.ShoppingCart userTest = new Models.ShoppingCart();

            userTest.checkName(userMockData.Fname, userMockData.Lname);

            Assert.Equal("Terrence", userMockData.Lname);
        }

        //Test the checkName function to ensure the correct last name datatype is saved in the system
        [Fact]
        public void Test6()
        {
            MockData userMockData = new MockData();
            Models.ShoppingCart userTest = new Models.ShoppingCart();

            userTest.checkName(userMockData.Fname, userMockData.Lname);

            Assert.StrictEqual("Linston", userMockData.Lname);
        }
        //Test the checkName function to ensure the correct first name datatype is saved in the system
        [Fact]
        public void Test7()
        {
            MockData userMockData = new MockData();
            Models.ShoppingCart userTest = new Models.ShoppingCart();

            userTest.checkName(userMockData.Fname, userMockData.Lname);

            Assert.StrictEqual("Tony", userMockData.Fname);
        }
    }
}
