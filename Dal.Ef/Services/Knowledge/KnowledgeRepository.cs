using Domain.Contract;
using Domain.Entities;
using Dto;
using Dto.DeviceDto;
using Dto.ReturnDto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility;
using Utility.SiteConstants;

namespace Dal.Ef.Services
{
    public class KnowledgeRepository : Repository<Knowledge>, IKnowledgeRepository
    {
        private readonly IContext ctx;

        public KnowledgeRepository(IContext ctx) : base(ctx as DbContext)
        {
            this.ctx = ctx;
        }
        public List<KnowledgeDto> GetByDetail(int Skip, int Count, GetKnowledgeDto dto)
        {
            var result = ctx.Knowledge.Include(p => p.KnowledgeImage).ThenInclude(q => q.Image).OrderByDescending(p => p.RegisterDate).
                Skip((Skip - 1) * Count).Take(Count).ToList();
            return result.Select(p => Functions.CreateKnowledgeDto(p)).ToList();
        }

       
        public KnowledgeDto GetById(Guid knowledgeId)
        {
            var pro = ctx.Knowledge.Include(p => p.KnowledgeImage).ThenInclude(q => q.Image).FirstOrDefault(p=>p.Id == knowledgeId);
            return Functions.CreateKnowledgeDto(pro);
        }
    }
}
