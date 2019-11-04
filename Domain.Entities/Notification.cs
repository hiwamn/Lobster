using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Notification:BaseEntity
    {
        public string Text { get; set; }
        public Guid UserId{ get; set; }
        public User User{ get; set; }
    }
}
