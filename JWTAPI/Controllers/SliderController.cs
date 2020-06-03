using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JWTAPI.Services;


namespace JWTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SliderController : ControllerBase
    {
        private readonly IListingService _categoryService;
        public SliderController(IListingService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<ActionResult> GetSlider()
        {
            var slider = await _categoryService.ListAsync6();
            return Ok(slider);
        }
    }
}