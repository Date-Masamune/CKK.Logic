using System;
namespace CKK.Logic.Models
{
	public class Customer
	{
		private int _Id; //instance variable for Id
		private string _Name; //instance variable for Name
		private string _Address; //instance variable for Address




		public int GetId()
		{
			return _Id; // returns the value of _Id to the client code 
		}


		public void SetId(int id)
		{
			_Id = id;
		}

		public string GetName()
		{
			return _Name; // returns the value of _Name to the client code
		}
		public void SetName(string name)
		{
			_Name = name;
		}


		public string GetAddress()
		{
			return _Address; // returns the value of _Address to the client code
		}
		public void SetAddress(string address)
		{
			_Address = address;
		}








	}
}

