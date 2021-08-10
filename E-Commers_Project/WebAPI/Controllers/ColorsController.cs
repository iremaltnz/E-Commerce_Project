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
    public class ColorsController : ControllerBase
    {
        IColorService _colorService;

        public ColorsController(IColorService  colorService)
        {
            _colorService = colorService;
        }

        [HttpGet("list")]
        public IActionResult Get()
        {

            var result = _colorService.ColorList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Color color)
        {
            var result = _colorService.ColorAdd(color);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);

        }


        [HttpPost("delete")]
        public IActionResult Delete(Color color)
        {
            var result = _colorService.ColorDelete(color);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);

        }

        [HttpPost("update")]
        public IActionResult Update(Color color)
        {
            var result = _colorService.ColorUpdate(color);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);

        }
    }
}
