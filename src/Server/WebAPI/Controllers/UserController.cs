using Application.Services;
using Application.Services.Interfaces;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<UserEntity> AddAsync(UserEntity userEntity)
        {
            return await _userService.AddAsync(userEntity);
        }

        [HttpGet]
        public async Task<UserEntity> LoginAsync(string login, string password)
        {
            return await _userService.Login(login, password);
        }
    }
}
