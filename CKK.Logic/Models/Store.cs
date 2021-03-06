using System;


namespace CKK.Logic.Models
{
   public class Store
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
         if (_Product1 == null)
         {
            _Product1 = prod;
         }

         else if (_Product2 == null)
         {
            _Product2 = prod;
         }

         else if (_Product3 == null)
         {
            _Product3 = prod;
         }

      }
      public void RemoveStoreItem(int productNum)
         {
            if (productNum == 1)
            {
               _Product1 = null;
            }

            else if (productNum == 2)
            {
               _Product2 = null;
            }

            else if (productNum == 3)
            {
               _Product3 = null;
            }
      }
      public Product GetStoreItem (int productNum)
            {
               if (productNum == 1)
               {
                  return  _Product1;
               }

               else if (productNum == 2)
               {
                  return  _Product2;
               }

               else if (productNum == 3)
               {
                  return  _Product3;
               }
               return null;
            }

          public Product FindStoreItemById(int Id)
            {
               if (_Product1.GetId() == Id)
               {
                  return _Product1;
               }

               else if (_Product2.GetId() == Id)
               {
                  return _Product2;
               }

               else if (_Product3.GetId() == Id)
               {
                  return _Product3;
               }
               return null;
            }
        

      

      


   }
}
