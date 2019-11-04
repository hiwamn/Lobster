using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationServices
{
    public interface ISendActiveCode
    {
        string Execute(string Mobile);
    }
}
