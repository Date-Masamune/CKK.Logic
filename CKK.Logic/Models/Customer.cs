using System;
namespace CKK.Logic
{
	public class Customer
	{
		private int _id; //instance variable for Id
		private string _name; //instance variable for Name
		private string _address; //instance variable for Address




		public int GetId()
		{
			return _id; // returns the value of _Id to the client code 
		}


		public void SetId(int id)
		{
			_id = id;
		}

		public string GetName()
		{
			return _name; // returns the value of _Name to the client code
		}
		public void SetName(string name)
		{
			_name = name;
		}


		public string GetAddress()
		{
			return _address; // returns the value of _Address to the client code
		}
		public void SetAddress(string address)
		{
			_address = address;
		}








	}
}

