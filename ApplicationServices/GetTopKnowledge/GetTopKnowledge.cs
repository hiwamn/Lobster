using Domain.Contract;
using Domain.Entities;
using Dto.DeviceDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;
using Utility.SiteConstants;

namespace ApplicationServices
{
    public class GetTopKnowledge : IGetTopKnowledge
    {
        private readonly IUnitOfWork unit;

        public GetTopKnowledge(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public string Execute(int BlockNumber,int Count, GetKnowledgeDto dto)
        {
            string result = Api.ToJson(unit.Knowledge.GetByDetail(BlockNumber, Count, dto));
            return result;
        }
    }
}
