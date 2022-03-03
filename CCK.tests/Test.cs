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
                //Console.WriteLine("Error occured");
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
            cust.SetId(1);
            prod.SetId(1);

                //Act
                shopping.AddProduct(prod, 10);
                int Actual = shopping.RemoveProduct(prod, 3).GetQuantity();

                //Assert
                Assert.Equal(7, Actual);
            }
            catch
            {


                throw new ArgumentNullException();
                //Console.WriteLine("Error occured");
                
            }

          
        }

        [Fact]
        public void ChecksAccTotal()
        {
            //Arrange
            

            //Act
            


            //Assert

        }
    }
 }

