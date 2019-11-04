using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public long RegisterDate { get; set; }
    }
}
