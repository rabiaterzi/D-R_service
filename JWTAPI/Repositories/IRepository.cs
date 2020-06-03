﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace JWTAPI.Repositories
{
	public interface IRepository
	{
		Task<IEnumerable<Kategori>> ListAsync();
		Task<IEnumerable<Alt_Kategori>> ListAsync2();
		Task<IEnumerable<AAlt_Kategori>> ListAsync3();
		Task<IEnumerable<Ürün_Kitap>> ListAsync4();
		Task<IEnumerable<Ürün_Diğer>> ListAsync5();
		Task<IEnumerable<Slider>> ListAsync6();
		string AddCategori(Kategori kategori);
		string AddSubCategori(Alt_Kategori akategori);
		string AddSSubCategori(AAlt_Kategori aakategori);
		string AddBook(Ürün_Kitap kitap);
		string AddProduct(Ürün_Diğer diger);
		string AddSlider(Slider slider);

	}
}
