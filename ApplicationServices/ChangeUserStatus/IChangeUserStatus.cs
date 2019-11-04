using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationServices
{
    public interface IChangeUserStatus
    {
        string Execute(Guid Id);
    }
}
