using Application.Commands;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IUserService : IAddAsync<UserEntity>, IUpdateAsync<UserEntity>
    {
        Task<UserEntity> Login(string login, string password);
    }
}
