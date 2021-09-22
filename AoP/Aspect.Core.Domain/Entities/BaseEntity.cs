using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspect.Core.Domain.Entities
{
    public abstract class BaseEntity : IEntity
    {
        public Guid Id { get; set; }
        public virtual string Title { get; set; }
        public virtual DateTime? CreatedAt { get; set; }
        public virtual DateTime? ModifiedAt { get; set; }

        public virtual int State { get; set; }
        public BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;
        }
    }
}
