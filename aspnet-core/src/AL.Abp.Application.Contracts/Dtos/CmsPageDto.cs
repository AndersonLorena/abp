using System;
using Volo.Abp.Application.Dtos;

namespace AL.Abp.Dtos
{
    public class CmsPageDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string HtmlContent { get; set; }
    }
}