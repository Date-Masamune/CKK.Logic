using System;


namespace CKK.Logic.Models
{
    class ShoppingCart
    {
        private Customer _Customer; //instance variable for _Customer
        private ShoppingCartItem _Product1; //instance variable for _Product1
        private ShoppingCartItem _Product2; //intsance variable for _Product2
        private ShoppingCartItem _Product3; //instance variable for _Product3


        public ShoppingCart(Customer cust)
        {
            _Customer = cust; 
        }


        public int GetCustomerId()
        {
            return _Customer.GetId();
        }

        public ShoppingCartItem AddProduct(int Product, quantity prod)
        {

        }




    }
}
