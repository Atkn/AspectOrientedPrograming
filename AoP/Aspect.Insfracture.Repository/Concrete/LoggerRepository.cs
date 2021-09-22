using Aspect.Core.Domain.Entities;
using Aspect.Insfracture.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspect.Insfracture.Repository.Concrete
{
    public class LoggerRepository<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly IEntityRepository<TEntity> _decorated;
        public LoggerRepository(IEntityRepository<TEntity> decorated)
        {
            _decorated = decorated;
        }
        private void Log(string msg, object arg = null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg, arg);
            Console.ResetColor();
        }
        public void Add(TEntity entity)
        {
            Log("In decorator - Before Adding {0}", entity);
            _decorated.Add(entity);
            Log("In decorator - After Adding {0}", entity);
        }

        public void Delete(TEntity entity)
        {
            Log("In decorator - Before Deleting {0}", entity);
            _decorated.Delete(entity);
            Log("In decorator - After Deleting {0}", entity);
        }

        public TEntity GetById(Guid id)
        {
            Log("In decorator - Before Deleting {0}", id);
            var result = _decorated.GetById(id);
            Log("In decorator - After Deleting {0}", id);
            return result;
        }

        public IEnumerable<TEntity> GetList()
        {
            Log("In decorator - Before Getting Entities");
            var result = _decorated.GetList();
            Log("In decorator - After Getting Entities");
            return result;
        }

        public void Update(TEntity entity)
        {
            Log("In decorator - Before Updating {0}", entity);
            _decorated.Update(entity);
            Log("In decorator - After Updating {0}", entity);
        }
    }
}
