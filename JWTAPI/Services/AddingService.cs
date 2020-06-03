using JWTAPI.Data;
using JWTAPI.Models;
using JWTAPI.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAPI.Services
{
	public class AddingService : IAddingService
	{
		private readonly IRepository _categoryRepository;
		public AddingService(IRepository categoryRepository)
		{
			this._categoryRepository = categoryRepository;
		}

		public string AddBook(Ürün_Kitap kitap)
		{
			return _categoryRepository.AddBook(kitap);
		}

		public string AddCategori(Kategori kategori)
		{
			string response= _categoryRepository.AddCategori(kategori);
			return response;
		}

		public string AddProduct(Ürün_Diğer diger)
		{
			return _categoryRepository.AddProduct(diger);
		}

		public string AddSlider(Slider slider)
		{
			return _categoryRepository.AddSlider(slider);
		}

		public string AddSSubCategori(AAlt_Kategori aakategori)
		{
			return _categoryRepository.AddSSubCategori(aakategori);
		}

		public string AddSubCategori(Alt_Kategori akategori)
		{
			return _categoryRepository.AddSubCategori(akategori);
		}
	}
}
