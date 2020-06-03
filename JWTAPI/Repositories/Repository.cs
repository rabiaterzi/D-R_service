using JWTAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JWTAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace JWTAPI.Repositories
{
	public class Repository : BaseRepository, IRepository
	{
		public Repository(DataContext context) : base(context)
		{

		}

		public string AddBook(Ürün_Kitap kitap)
		{
			var result = _context.Ürün_Kitaplar.Where(x => x.Id.Equals(kitap.Id)).ToListAsync();

			if (result == null)
			{
				_context.Ürün_Kitaplar.Add(new Ürün_Kitap
				{
					Id = kitap.Id,
					Author = kitap.Author,
					Name = kitap.Name,
					Photo = kitap.Photo,
					CoverType = kitap.CoverType,
					Price = kitap.Price,
					Point = kitap.Point,
					Discount = kitap.Discount,
					Publisher = kitap.Publisher,
					SubC_Id = kitap.SubC_Id,
				});
				return "eklendi";
			}
			else return "eklenmedi";
		}

		public string AddCategori(Kategori kategori)
		{
			var result = _context.Kategoriler.Where(x => x.Id.Equals(kategori.Id)).ToListAsync();             
			if (result == null)
			{
				_context.Kategoriler.Add(new Kategori
				{
					Id = kategori.Id,
					Name = kategori.Name,
				});
				return "eklendi";
			}
            return "eklenmedi";
			
		}

		public string AddProduct(Ürün_Diğer diger)
		{
			var result = _context.Ürün_Diğerleri.Where(x => x.Id.Equals(diger.Id)).ToListAsync();

			if (result == null)
			{
				_context.Ürün_Diğerleri.Add(new Ürün_Diğer
				{
					Id = diger.Id,
					Name = diger.Name,
					Photo = diger.Photo,
					Price = diger.Price,
					Point = diger.Point,
					Discount = diger.Discount,
					Brand = diger.Brand,
					P_Type = diger.P_Type,
				});
				return "eklendi";
			}
			else return "eklenmedi";
		}

		public string AddSlider(Slider slider)
		{
			var result =  _context.Sliders.Where(x => x.Id.Equals(slider.Id)).ToListAsync();

			if (result == null)
			{
				_context.Sliders.Add(new Slider
				{
					Id = slider.Id,
					Photo = slider.Photo
				});
				return "eklendi";
			}
			else return "eklenmedi";
		}

		public string AddSSubCategori(AAlt_Kategori aakategori)
		{
			var result =  _context.AAlt_Kategoriler.Where(x => x.Id.Equals(aakategori.Id)).ToListAsync();

			if (result == null)
			{
				_context.AAlt_Kategoriler.Add(new AAlt_Kategori
				{
					Id = aakategori.Id,
					Name = aakategori.Name,
					SubC_Id = aakategori.SubC_Id
				});
				return "eklendi";
			}
			else return "eklenmedi";
		}
		
		public string AddSubCategori(Alt_Kategori akategori)
		{
			var result = _context.Kitaplar.Where(x => x.Id.Equals(akategori.Id)).ToListAsync();

			if (result == null)
			{
				_context.Kitaplar.Add(new Alt_Kategori
				{
					Id = akategori.Id,
					Name = akategori.Name,
					Category_Id = akategori.Category_Id
				});
				return "eklendi";
			}
			else return "eklenmedi";
		}

		public async Task<IEnumerable<Kategori>> ListAsync()
		{
			return await _context.Kategoriler.ToListAsync();
		}

		public async Task<IEnumerable<Alt_Kategori>> ListAsync2()
		{
			return await _context.Kitaplar.ToListAsync();
		}

		public async Task<IEnumerable<AAlt_Kategori>> ListAsync3()
		{
			return await _context.AAlt_Kategoriler.ToListAsync();
		}

		public async Task<IEnumerable<Ürün_Kitap>> ListAsync4()
		{
			return await _context.Ürün_Kitaplar.ToListAsync();
		}

  		public async Task<IEnumerable<Ürün_Diğer>> ListAsync5()
		{
			return await _context.Ürün_Diğerleri.ToListAsync();
		}

		public async Task<IEnumerable<Slider>> ListAsync6()
		{
			return await _context.Sliders.ToListAsync();
		}
	}
}