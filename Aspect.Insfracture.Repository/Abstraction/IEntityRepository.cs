using Aspect.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspect.Insfracture.Repository.Abstraction
{
    public interface IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);

        void Update(TEntity entity);

        IEnumerable<TEntity> GetList();

        TEntity GetById(Guid id);



    }
}
