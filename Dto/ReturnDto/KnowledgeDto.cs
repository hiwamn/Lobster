using System;
using System.Collections.Generic;
using System.Text;

namespace Dto.ReturnDto
{
    public class KnowledgeDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public long RegisterDate { get; set; }

        public List<string> Images { get; set; }
    }
}
