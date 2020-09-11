using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Core.Models.SearchModel
{
	public class LocationItem
	{
		//public bool isFavourite { get; set; }
		public string title { get; set; }
		public string subtitle { get; set; }
		public string id { get; set; }
		public Position position { get; set; }


		public LocationItem(string title, string subtitle, string id, Position position)
		{
			//this.isFavourite = false;
			this.title = title;
			this.subtitle = subtitle;
			this.id = id;
			this.position = position;
		}
	}
}
