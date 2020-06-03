using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JWTAPI.Models
{
	public class Kategori
	{
		[Required]
		public int Id { get; set; }
		public string Name { get; set; }
		//public IList<Ürün_Diğer> Ürün_Diğerleri { get; set; } = new List<Ürün_Diğer>();
	}
}
