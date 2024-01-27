using System.ComponentModel.DataAnnotations;

namespace AL.Abp.Dtos
{
    public class CreateUpdateCmsPageDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        [StringLength(4096)]
        public string HtmlContent { get; set; }
    }
}