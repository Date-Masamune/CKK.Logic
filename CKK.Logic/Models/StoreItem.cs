
namespace CKK.Logic
{
	class StoreItem
	{
		private Product _product; //instance variable for _Product 
		private int _quantity; //instance variable for _Quantity 


		public StoreItem(Product product, int quantity)
		{
			_product = product;
			_quantity = quantity;
		}


		public int GetQuantity()
		{
			return _quantity; // returns the value of _Quantity to the client code
		}


		public void SetQuantity(int quantity)
		{
			_quantity = quantity;
		}


		public Product GetProduct()
		{
			return _product; // returns the value of _Product to the client code
		}


		public void SetProduct(Product product)
		{
			_product = product;
		}
	}
}

