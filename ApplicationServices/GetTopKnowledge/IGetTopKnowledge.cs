using Dto.DeviceDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationServices
{
    public interface IGetTopKnowledge
    {
        string Execute(int BlockNumber, int Count, GetKnowledgeDto dto);
    }
}
