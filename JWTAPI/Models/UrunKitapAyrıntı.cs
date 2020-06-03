using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JWTAPI.Models
{
	public class UrunKitapAyrıntı
	{
		[Required]
		[Key]
		public int UrunId { get; set; }
		public string Explanation { get; set; }
		public int DoughType { get; set; }
		public int PageNumber { get; set; }
		public double Dimensions { get; set; }
		public int FirstYear { get; set; }
		public int PrintNumber { get; set; }
		public  string Language { get; set; }
	}
}
