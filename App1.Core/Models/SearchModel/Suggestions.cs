using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Core.Models.SearchModel
{
	public class Suggestions
	{
		public List<Item> items { get; set; }
	}
	public class Item
	{
		public string title { get; set; }
		public string id { get; set; }
		public string resultType { get; set; }
		public string localityType { get; set; }
		public Position position { get; set; }
	}
	public class Address
	{
		public string country { get; set; }
		public string state { get; set; }
		public string county { get; set; }
		public string city { get; set; }
	}
	public class LookUp
	{
		public string id { get; set; }
		public AddressLookUp address { get; set; }
		public Position position { get; set; }
	}
	public class Position
	{
		public string lat { get; set; }
		public string lng { get; set; }
	}

	public class AddressLookUp
	{
		public string countryName { get; set; }
		public string countryCode { get; set; }
		public string state { get; set; }
		public string county { get; set; }
		public string city { get; set; }
	}
}
