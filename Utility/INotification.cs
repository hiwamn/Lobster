using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public interface INotification
    {
        Task SendAsync(params string[] Params);
    }
}
