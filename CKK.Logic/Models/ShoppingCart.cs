using System;


namespace CKK.Logic.Models
{
    class ShoppingCart
    {
        private Customer _Customer; //instance variable for _Customer
        private ShoppingCartItem _Product1; //instance variable for _Product1_Prod
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

        public ShoppingCartItem AddProduct(int quantity, Product prod)
        {

        }

        public ShoppingCartItem AddProduct(Product prod)
        {

        }

        public ShoppingCartItem RemoveProduct(int quantity, Product prod)
        {

        }

        ShoppingCartItem GetProductByld(int id)
        {
            if(_Product1.GetProduct().GetId() == id)
            {
                return _Product1;
            }

            if(_Product2.GetProduct().GetId() == id)
            {
                return _Product2;
            }

            if(_Product3.GetProduct().GetId() == id)
            {
                return _Product3;
            }
        }

        public decimal GetTotal()
        {
             
        }
        
        ShoppingCartItem GetProduct(int productNum)
        {
            
        }

    }
}
