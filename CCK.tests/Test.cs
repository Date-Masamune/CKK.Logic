using System;
using Xunit;
using CKK.Logic.Models;

namespace CCK.tests
{
    public class Test
    {
        
        
        [Fact]
        public void CheckAndAddProduct()
        {
            try
            { 
            Customer cust = new Customer();
            ShoppingCart shopping = new ShoppingCart(cust);
            Product prod = new Product();
            //Arrange
            cust.SetId(1);
            prod.SetId(1);


                //Act
                int Actual = shopping.AddProduct(prod, 5).GetQuantity();

            //Assert
            Assert.Equal(5, Actual);
        
            }

            catch
            {
                throw new ArgumentNullException();
                
            }
        }


        [Fact]
        public void CheckRemovingProduct()
        {
            try
            { 
            Customer cust = new Customer();
            ShoppingCart shopping = new ShoppingCart(cust);
            Product prod = new Product();

            //Arrange
            cust.SetId(2);
            prod.SetId(2);

                //Act
                var shop = shopping.AddProduct(prod, 4);
                var Actual = shopping.RemoveProduct(prod, 2).GetQuantity();

                //Assert
                Assert.Equal(2, Actual);
            }
            catch
            {
                

                throw new ArgumentNullException();
                

            }

          
        }

        [Fact]
        public void ChecksAccTotal()
        {
            try
            {
                Customer cust = new Customer();
                ShoppingCart shopping = new ShoppingCart(cust);
                Product prod = new Product();
                Product prod2 = new Product();
                Product prod3 = new Product();

                //Arrange
                prod.SetId(1);
                prod2.SetId(2);
                prod3.SetId(3);

                prod.SetPrice(5);
                prod2.SetPrice(5);
                prod3.SetPrice(5);
                //Act
                shopping.AddProduct(prod, 1);
                shopping.AddProduct(prod2, 2);
                shopping.AddProduct(prod3, 3);

                var actual = shopping.GetTotal();
                //Assert
                Assert.Equal(30, actual);
                
            }

            catch
            {
                throw new ArgumentNullException();

            }
        }
    }
 }

