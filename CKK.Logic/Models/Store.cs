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



      }


   }
}
