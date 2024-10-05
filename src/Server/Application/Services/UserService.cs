using Application.Repositories;
using Application.Services.Interfaces;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<UserEntity> AddAsync(UserEntity entity)
        {
           return await _userRepository.AddAsync(entity);
        }

        public async Task<UserEntity> Login(string login, string password)
        {
            return await _userRepository.Login(login, password);
        }

        public async Task<UserEntity> UpdateAsync(UserEntity entity)
        {
            return await _userRepository.UpdateAsync(entity);
        }
    }
}
