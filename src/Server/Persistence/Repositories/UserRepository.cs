using Application.Repositories;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AplicationContext _context;

        public UserRepository(AplicationContext context)
        {
            _context = context;
        }

        public async Task<UserEntity> AddAsync(UserEntity entity)
        {
            await _context.Users.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<UserEntity> Login(string login, string password)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Login == login);
        }

        public Task<UserEntity> UpdateAsync(UserEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
