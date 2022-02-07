using System;
namespace CKK.Logic.Models
{
	class StoreItem
	{
		private Product _Product; //instance variable for _Product 
		private int _Quantity; //instance variable for _Quantity 


		public StoreItem(Product product, int quantity)
		{
			_Product = product;
			_Quantity = quantity;
		}


		public int GetQuantity()
		{
			return _Quantity; // returns the value of _Quantity to the client code
		}


		public void SetQuantity(int quantity)
		{
			_Quantity = quantity;
		}


		public Product GetProduct()
		{
			return _Product; // returns the value of _Product to the client code
		}


		public void SetProduct(Product product)
		{
			_Product = product;
		}
	}
}

