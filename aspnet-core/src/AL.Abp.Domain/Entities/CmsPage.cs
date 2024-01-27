using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace AL.Abp.Entities
{
    public class CmsPage : AuditedAggregateRoot<Guid>
    {
        public string Name { get; protected set; }

        public string HtmlContent { get; protected set; }

        public CmsPage(string name, string htmlContent)
            : base()
        {
            Name = name;
            HtmlContent = htmlContent;

            Validade();
        }

        private void Validade()
        {
            if (string.IsNullOrEmpty(Name) || Name.Length > DomainConsts.CmsPageNameMaxSize)
                throw new BusinessException(DomainConsts.CmsPageNameValidationError);

            if (string.IsNullOrEmpty(HtmlContent) || HtmlContent.Length > DomainConsts.CmsPageHtmlContentMaxSize)
                throw new BusinessException(DomainConsts.CmsPageHtmlContentValidationError);
        }
    }
}