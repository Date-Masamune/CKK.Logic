using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
   class Store
   {

      private int _Id;  //instance variable for _Id
      private string _Name; //instance variable for _Name
      private Product _Product1; //instance variable for _Product1
      private Product _Product2; //instance variable for _Product2
      private Product _Product3; //instance variable for _Product3

      

      public int GetId()
      {
         return _Id;
      }

      public void SetId(int id)
      {
         _Id = id;
      }

      public string GetName()
      {
         return _Name;
      }

      public void SetName(string name)
      {
         _Name = name;
      }

      public void AddStoreItem(Product prod)
      {
         //Adds a product to the next availabe product(product1, product2, product3).
          Product1, _Product2, _Product3;

         //If there are  no available product, it will not a product at all
         // If there is an item in spot two, but not spot one or three, 
         //then it should put the item in spot 1( the next available spot)
         //should be an imbetted loop
            if ( _Product1 = null _Product2 =null _Product3 = null)
         {
            Console.WriteLine("Don't add a product");
         }

         else if( _Product1 = available)
         {
            //put item in spot 1
         }

      }

      public void RemoveStoreItem(int productNum)
      {
         // remove product from the desire product

         // if there are no product does nothing
         // If product is out of range, does nothing
         //It should not shift/move itemps up in the list when things are removed
         // probably a look here to do it


      }

      public Product GetStoreItem(int productNum)
      {
         //This is different from FindByld. This methid gets the product by it's position (product1, 2, 3)
           //Should return correct product
         
         //If it is an invalid productNumber, the it will return null
         //If there is not an item in the desire spot, it will return null
      }

      public Product FindStoreItemByld(int id)
      {

         //This will return the product that has the same Id(if there is one)
         //If there are not items with that id, then it should return null
         //If there are more then one item with that Id, then it will return the first one

      }


   }
}
