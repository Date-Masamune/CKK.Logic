
namespace CKK.Logic
{
	class Product
	{
		private int _id; //instance variable for _Id
		private string _name; //instance variable for _Name
		private decimal _price; //instance variable for _Price


		public int GetId()
		{
			return _id; // returns the value of _Id to the client code
		}


		public void SetId(int id)
		{
			_id = id;
		}


		public void GetName()
		{

		}


		public void SetName(string name)
		{
			_name = name;
		}


		public decimal GetPrice()
		{
			return _price; // returns the value of _Price to the client code
		}


		public void SetPrice(decimal price)
		{
			_price = price;
		}
	}
}

