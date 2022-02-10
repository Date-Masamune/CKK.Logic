
namespace CKK.Logic.Models
{
	public class ShoppingCartItem
	{
		private Product _Product; //instance variable for _Product 
		private int _Quantity; //instance variable for _Quantity 


		public ShoppingCartItem(Product product, int quantity)
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


	   public decimal GetTotal()
      {
			return Total;
      }

	}
}
