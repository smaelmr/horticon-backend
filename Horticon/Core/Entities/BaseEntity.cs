using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; set; }
        public virtual int Sytem { get; set; }
        public virtual int Lot { get; set; }
    }

}
