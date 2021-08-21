using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController:ControllerBase
    {
       IUserService _userService;
        [HttpPost("login")]
        public IActionResult Login(UserForLoginDto userForLoginDto )
        {
            var result = _userService.Login(userForLoginDto);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpPost("register")]
        public IActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var result = _userService.Register(userForRegisterDto,userForRegisterDto.password);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }
    }
}
