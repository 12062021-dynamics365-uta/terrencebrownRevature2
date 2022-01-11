namespace Models
{
    interface IShoppingCart
    {
        public void itemUserSelected(string Fname, string Lname, string selectedProduct);

        public void updateUserCheck();

        public void getHistory(string Fname, string Lname);

        public void checkName(string Fname, string Lname);

        
    }
}
