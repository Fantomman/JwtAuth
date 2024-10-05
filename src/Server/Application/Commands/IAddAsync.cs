using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public interface IAddAsync<TEntity> where TEntity : class
    {
        Task<TEntity> AddAsync(TEntity entity);
    }
}
