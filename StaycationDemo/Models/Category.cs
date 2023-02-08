using System.Collections.Generic;
using System.IO.Pipelines;

namespace StaycationDemo.Models
{
	public class Category
	{
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
		public string Description { get; set; }
	}
}