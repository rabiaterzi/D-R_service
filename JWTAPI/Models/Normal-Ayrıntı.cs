using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAPI.Models
{
	public class Normal_Ayrıntı
	{
		public int Id { get; set; }
		public string Photo { get; set; }
		public double Point { get; set; }
		public string Name { get; set; }
		public string Author { get; set; }
		public string CoverType { get; set; }
		public string Publisher { get; set; }
		public int Discount { get; set; }
		public double Price { get; set; }
		public string Explanation { get; set; }
		public int DoughType { get; set; }
		public int PageNumber { get; set; }
		public double Dimensions { get; set; }
		public int FirstYear { get; set; }
		public int PrintNumber { get; set; }
		public string Language { get; set; }
	}
}
