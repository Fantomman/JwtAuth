using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public interface IUpdateAsync<TEntity> where TEntity : class
    {
        Task<TEntity> UpdateAsync(TEntity entity);
    }
}
