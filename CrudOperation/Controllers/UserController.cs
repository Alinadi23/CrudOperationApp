using Application.DTOs;
using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudOperation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _userService.GetAllUser();
            return Ok(new { Success = true, data = result });
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(UserVM user)
        {
            await _userService.Create(user);
            return Ok(new { Success = true });
        }

        [HttpPut]
        [Route("Update")]

        public async Task<IActionResult> Update(UserVM user)
        {
            await _userService.Update(user);
            return Ok(new { Success = true });
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _userService.Delete(id);
            return Ok(new { Success = true });
        }
    }
}
