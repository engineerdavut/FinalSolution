using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
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
    public class ProductsController : ControllerBase
    {    //naming convention

        IProductService _productService;
        // gevsek bagimlilik loose coupling
        //product manager newlememiz gerkiyor. newlersek bagıimli oluruz.
        //Onun için IoC -- Invertion of Control
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            // Bagimlilik zinciri olustu. dependcy chain
            // IProductService productService = new ProductManager(new EfProductDal());
            var result = _productService.GetAll();
            if (result.success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }
        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult BetById(int id)
        {

            // Bagimlilik zinciri olustu. dependcy chain
            // IProductService productService = new ProductManager(new EfProductDal());
            var result = _productService.GetById(id);
            if (result.success)
            {
                return Ok(result);
            }

            return BadRequest(result);


        }
    }
}
