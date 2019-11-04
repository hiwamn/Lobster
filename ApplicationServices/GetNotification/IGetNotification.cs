using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationServices
{
    public interface IGetNotification
    {
        string Execute(Guid UserId);
    }
}
