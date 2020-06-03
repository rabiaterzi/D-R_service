using JWTAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAPI.Services
{
	public interface IAddingService
	{
	    string AddCategori(Kategori kategori);
		string AddSubCategori(Alt_Kategori akategori);
		string AddSSubCategori(AAlt_Kategori aakategori);
		string AddBook(Ürün_Kitap kitap);
		string AddProduct(Ürün_Diğer diger);
		string AddSlider(Slider slider);
	}
}
