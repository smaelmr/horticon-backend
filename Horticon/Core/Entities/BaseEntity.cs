using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; set; }
    }

}
