using Domain.Entities;
using Dto.DeviceDto;
using Dto.ReturnDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contract
{
    public interface IKnowledgeRepository : IRepository<Knowledge>
    {
        List<KnowledgeDto> GetByDetail(int Skip, int Count, GetKnowledgeDto dto);
        KnowledgeDto GetById(Guid knowledgeId);
    }
}
