using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Device: BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string PushId{ get; set; }
        public List<Notification> Notification { get; set; }

    }


}


