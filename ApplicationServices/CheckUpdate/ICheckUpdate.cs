using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationServices
{
    public interface ICheckUpdate
    {
        string Execute(string Version);
    }
}
