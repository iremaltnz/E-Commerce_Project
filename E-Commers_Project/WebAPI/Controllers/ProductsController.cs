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
    public class ProductsController : ControllerBase
    {

        IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("list")]
        public IActionResult List()
        {
            
            var result = _productService.ProductList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.ProductAdd(product);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);

        }


        [HttpPost("delete")]
        public IActionResult Delete(Product product)
        {
            var result = _productService.ProductDelete(product);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpPost("update")]
        public IActionResult Update(Product product)
        {
            var result = _productService.ProductUpdate(product);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }
         [HttpGet("getbydetail")]
        public IActionResult GetProductDetail(int productId)
        {

            var result = _productService.GetProductDetailsById(productId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbycategory")]
        public IActionResult GetByCategory(int categoryId)
        {

            var result = _productService.GetByCategory(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbyBrand")]
        public IActionResult GetByBrand(int brandId)
        {

            var result = _productService.GetByBrand(brandId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbycolor")]
        public IActionResult GetByColor(int colorId)
        {

            var result = _productService.GetByColor(colorId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}