using Aspect.Core.Domain.Entities;
using Aspect.Insfracture.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspect.Insfracture.Repository.Concrete
{
    public class EntityRepository<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        public void Add(TEntity entity)
        {
            Console.WriteLine("Added entity:{0}", entity);
        }

        public void Delete(TEntity entity)
        {
            Console.WriteLine("Dlete entity:{0}", entity);
        }

        public TEntity GetById(Guid id)
        {
            Console.WriteLine("get entity:{0}", id);
            return default(TEntity);
        }

        public IEnumerable<TEntity> GetList()
        {
            Console.WriteLine("Get List");
            return null;
        }

        public void Update(TEntity entity)
        {
            Console.WriteLine("Updating entity:{0}", entity);
        }
    }
}
