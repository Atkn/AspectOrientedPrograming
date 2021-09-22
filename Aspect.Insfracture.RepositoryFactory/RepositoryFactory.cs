using Aspect.Core.Domain.Entities;
using Aspect.Insfracture.Proxy;
using Aspect.Insfracture.Repository.Abstraction;
using Aspect.Insfracture.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspect.Insfracture.RepositoryFactory
{
    public static class RepositoryFactory
    {
        public static IEntityRepository<T> Create<T>() where T : class , IEntity, new()
        {
            var repository = new EntityRepository<T>();
            var dynamicProxy = new DynamicProxy<IEntityRepository<T>>(repository);
            var transparent = dynamicProxy.GetTransparentProxy() as IEntityRepository<T>;
            return transparent;
        }
    }
}
