using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JWTAPI.Data;
using Microsoft.EntityFrameworkCore;
using JWTAPI.Services;
using JWTAPI.Repositories;
using AutoMapper;
using JWTAPI.Models;
using JWTAPI.Resources;


namespace JWTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategorilerController : ControllerBase
    {
        private readonly IListingService _categoryService;
        private readonly IMapper _mapper;
        private DataContext _context;
        public KategorilerController(IListingService categoryService,IMapper mapper,DataContext context)
        {
            _categoryService = categoryService;
            _mapper = mapper;
            _context = context;
        }
        [HttpGet]
        public async Task<IEnumerable<CategoryResource>> GetCategories()
        { 
            var values = await _categoryService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Kategori>, IEnumerable<CategoryResource>>(values);
            return resources;
        }
        /*[HttpGet("{id}")]
        public async Task<ActionResult> GetCategory(int id)
        {
            var value = await _context.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(value);
        }*/
        [HttpGet("kitap")]
        public async Task<ActionResult> GetSubCategory()
        {
            var subcategory = await _categoryService.ListAsync2();
            return Ok(subcategory);
        }
        [HttpGet("kitap/urunno={id}")]
        public async Task<ActionResult> GetAyrıntı(int id)
        {
            var result = from a in _context.Ürün_Kitaplar
                         join b in _context.UKitapAyrıntıları on a.Id equals b.UrunId
                         select new Normal_Ayrıntı
                         {                      
                             Id = a.Id,
                             Author = a.Author,
                             CoverType = a.CoverType,
                             Discount = a.Discount,
                             Name = a.Name,
                             Photo = a.Photo,
                             Point=a.Point,
                             Publisher=a.Publisher,
                             Price=a.Price,
                             Explanation=b.Explanation,
                             DoughType=b.DoughType,
                             PageNumber=b.PageNumber,
                             Dimensions=b.Dimensions,
                             FirstYear=b.FirstYear,
                             PrintNumber=b.PrintNumber,
                             Language=b.Language,
                         };
            var urun1 = result.Where(x => x.Id.Equals(id));
            await urun1.ToListAsync();
            return Ok(urun1);
           
            /*var urun1 = _context.Ürün_Kitaplar.Where(x => x.Id.Equals(id));
            var urun2 = _context.UKitapAyrıntıları.Where(x => x.UrunId.Equals(id));
            var urun3= urun1.Union(urun2);
            return urun3;*/
        }

        [HttpGet("kitap/edebiyat")]
        public async Task<ActionResult> GetSSubCategory()
        {
            var ssubcategory = await _categoryService.ListAsync3();
            return Ok(ssubcategory);
        }

        [HttpGet("kitap/edebiyat/sort={sort},{sort2}/mediatypes={media}/price={num1},{num2}")]
        public async Task<ActionResult> GetFilter(string sort,string sort2,string media,int num1,int num2)
        {
                var urun1 = _context.Ürün_Kitaplar.Where(x => x.CoverType.Equals(media));
            if(num1==0 && num2==0)                                                                 
            {
                await urun1.ToListAsync();
                if(sort=="price" && sort2=="desc")
                {
                    var urun2= urun1.OrderByDescending(x => x.Price);
                    await urun2.ToListAsync();
                    return Ok(urun2);
                }
                else if(sort==" " && sort2==" ")
                {
                    await urun1.ToListAsync();
                    return Ok(urun1);
                }
                else if(sort=="price" && sort2=="asc")
                {
                    var urun2 = urun1.OrderBy(x => x.Price);
                    await urun2.ToListAsync();
                    return Ok(urun2);
                }
                else if (sort == "discount" && sort2 == "desc")
                {
                    var urun2 = urun1.OrderByDescending(x => x.Discount);
                    await urun2.ToListAsync();
                    return Ok(urun2);
                }
                else if (sort == "discount" && sort2 == "asc")
                {
                    var urun2 = urun1.OrderBy(x => x.Discount);
                    await urun2.ToListAsync();
                    return Ok(urun2);
                }
                else if (sort == "name" && sort2 == "desc")
                {
                    var urun2 = urun1.OrderByDescending(x => x.Name);
                    await urun2.ToListAsync();
                    return Ok(urun2);
                }
                else if (sort == "name" && sort2 == "asc")
                {
                    var urun2 = urun1.OrderBy(x => x.Name);
                    await urun2.ToListAsync();
                    return Ok(urun2);
                }

            }
            else
            {
                var urun3 = urun1.Where(x => x.Price >= num1 && x.Price < num2);
                if (sort == "price" && sort2 == "desc")
                {
                    var urun2 = urun3.OrderByDescending(x => x.Price);
                    await urun2.ToListAsync();
                    return Ok(urun2);
                }
                else if (sort == " " && sort2 == " ")
                {
                    await urun3.ToListAsync();
                    return Ok(urun3);
                }
                else if (sort == "price" && sort2 == "asc")
                {
                    var urun2 = urun3.OrderBy(x => x.Price);
                    await urun2.ToListAsync();
                    return Ok(urun2);
                }
                else if (sort == "discount" && sort2 == "desc")
                {
                    var urun2 = urun3.OrderByDescending(x => x.Discount);
                    await urun2.ToListAsync();
                    return Ok(urun2);
                }
                else if (sort == "discount" && sort2 == "asc")
                {
                    var urun2 = urun3.OrderBy(x => x.Discount);
                    await urun2.ToListAsync();
                    return Ok(urun2);
                }
                else if (sort == "name" && sort2 == "desc")
                {
                    var urun2 = urun3.OrderByDescending(x => x.Name);
                    await urun2.ToListAsync();
                    return Ok(urun2);
                }
                else if (sort == "name" && sort2 == "asc")
                {
                    var urun2 = urun3.OrderBy(x => x.Name);
                    await urun2.ToListAsync();
                    return Ok(urun2);
                }
            }            
            return Ok(urun1);
            //await urun1.ToListAsync();
            //var urun2= _context.Ürün_Kitaplar.FindAsync(urun1.Where(x=>x.Id.Equals(_context.FindAsync())))
            
               
            // var mediatype = _context.Ürün_Kitaplar.Where(x => x.CoverType.Equals(media))&& _context.UKitapAyrıntıları.Where(x=>x.Language.Equals(language);
            //var listele=await _context.FindAsync(x=>x.)
            // listele = await mediatype.ToListAsync();
            //return Ok(listele);
        }
    }
}