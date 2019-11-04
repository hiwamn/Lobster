using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationServices
{
    public interface ILogin
    {
        string Execute(string Mobile,string Password,string DeviceId);
    }
}
