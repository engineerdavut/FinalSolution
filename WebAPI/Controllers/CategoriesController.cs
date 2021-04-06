using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;
        // gevsek bagimlilik loose coupling
        //category manager newlememiz gerkiyor. newlersek bagıimli oluruz.
        //Onun için IoC -- Invertion of Control
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            // Bagimlilik zinciri olustu. dependcy chain
            // IcategoryService categoryService = new categoryManager(new EfcategoryDal());
            var result = _categoryService.GetAll();
            if (result.success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }
        [HttpPost("add")]
        public IActionResult Add(Category category)
        {
            var result = _categoryService.Add(category);
            if (result.success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {

            // Bagimlilik zinciri olustu. dependcy chain
            // IcategoryService categoryService = new categoryManager(new EfcategoryDal());
            var result = _categoryService.GetById(id);
            if (result.success)
            {
                return Ok(result);
            }

            return BadRequest(result);


        }

    }
}
