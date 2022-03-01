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
            // checks for valid quantity and product; adds quantity if found
            if(quantity < 1)
            {
                return null;
            }

            if(_Product1 != null && _Product1.GetProduct().GetId() == prod.GetId() )
            {
                _Product1.SetQuantity(_Product1.GetQuantity() + quantity);
                return _Product1;
            }

            if(_Product2 != null  &&  _Product2.GetProduct().GetId() == prod.GetId() )
                {
                _Product2.SetQuantity(_Product2.GetQuantity() + quantity);
                return _Product2;
                }

            if(_Product3 != null && _Product3.GetProduct().GetId() == prod.GetId() )
            {
                _Product3.SetQuantity(_Product3.GetQuantity() + quantity); 
                return _Product3;
                   { 
                     
                   }        
            }

            //Adds a new Product if there is none
            if (_Product1 == null)
            {
                _Product1 = new ShoppingCartItem(prod, quantity);

                return _Product1;
            }

            if(_Product2 == null)
            {
                _Product2 = new ShoppingCartItem(prod, quantity);

                return _Product2;
            }

            if(_Product3 == null)
            {
                _Product3 = new ShoppingCartItem(prod, quantity);

                return _Product3;
            }
     
            return null;
        }

        public ShoppingCartItem AddProduct(Product prod)
        {
            return AddProduct(1, prod);
        }
        public ShoppingCartItem RemoveProduct(int quantity, Product prod)
        {
            // check for valid quantity, removes if found. 
            if(quantity < 1)
            {
                return null;
            }

            if(_Product1 != null && _Product1.GetProduct().GetId() == prod.GetId() )
            {   
                //returns the product changed or null
                if(_Product1.GetQuantity() < 1)
                {
                    return null;
                }
                _Product1.SetQuantity(_Product1.GetProduct().GetId() - quantity);
                return _Product1;
            }

            if(_Product2 != null && _Product2.GetProduct().GetId() == prod.GetId() )
            {
                if(_Product2.GetQuantity() < 1)
                {
                    return null;
                }

                _Product2.SetQuantity(_Product2.GetProduct().GetId() - quantity);
                return _Product2;
            }

            if(_Product3 != null && _Product3.GetProduct().GetId() == prod.GetId() )
            {       
                if(_Product3.GetQuantity() < 1)
                {
                    return null;
                }
                _Product3.SetQuantity(_Product3.GetProduct().GetId() - quantity);
                return _Product3;
            }
            return null;
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
            return null;
        }

        public decimal GetTotal()
        {
            
            
        }


        ShoppingCartItem GetProduct(int productNum)
        {
            
            
        }

    }
}
