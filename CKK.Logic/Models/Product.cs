
namespace CKK.Logic.Models
{
	class Product
	{
		private int _Id; //instance variable for _Id
		private string _Name; //instance variable for _Name
		private decimal _Price; //instance variable for _Price


		public int GetId()
		{
			return _Id; // returns the value of _Id to the client code
		}


		public void SetId(int id)
		{
			_Id = id;
		}


		public void GetName()
		{

		}


		public void SetName(string name)
		{
			_Name = name;
		}


		public decimal GetPrice()
		{
			return _Price; // returns the value of _Price to the client code
		}


		public void SetPrice(decimal price)
		{
			_Price = price;
		}
	}
}

