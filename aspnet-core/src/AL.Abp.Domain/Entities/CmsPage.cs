using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace AL.Abp.Entities
{
    public class CmsPage : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public string HtmlContent { get; set; }
    }
}