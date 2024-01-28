using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using AL.Abp.Dtos;
using Xunit;

namespace AL.Abp.CmsPage.Dtos
{
    public class CreateUpdateCmsPageDtoTests
    {
        [Fact]
        public void Should_Validate_Required_Fields()
        {
            // Arrange
            var dto = new CreateUpdateCmsPageDto();

            // Act
            var validationResults = ValidateModel(dto);

            // Assert
            Assert.Contains(validationResults, v => v.MemberNames.Contains(nameof(CreateUpdateCmsPageDto.Name)) && v.ErrorMessage.Contains("required"));
            Assert.Contains(validationResults, v => v.MemberNames.Contains(nameof(CreateUpdateCmsPageDto.HtmlContent)) && v.ErrorMessage.Contains("required"));
        }

        [Theory]
        [InlineData("NewZelandCityName_TaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahu")] // Substitua com um nome que exceda 128 caracteres
        public void Should_Validate_Name_MaxStringLength(string name)
        {
            // Arrange
            var dto = new CreateUpdateCmsPageDto
            {
                Name = name,
                HtmlContent = "Valid HtmlContent" // Assegure-se de que este campo seja válido
            };

            // Act
            var validationResults = ValidateModel(dto);

            // Assert
            Assert.Contains(validationResults, v => v.MemberNames.Contains(nameof(CreateUpdateCmsPageDto.Name)) && v.ErrorMessage.Contains("maximum length"));
        }

        [Theory]
        [InlineData("NewZelandCityName_TaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahu")] // Substitua com conteúdo HTML que exceda 4096 caracteres
        public void Should_Validate_HtmlContent_MaxStringLength(string htmlContent)
        {
            // Arrange
            var dto = new CreateUpdateCmsPageDto
            {
                Name = "Valid Name", // Assegure-se de que este campo seja válido
                HtmlContent = htmlContent
            };

            // Act
            var validationResults = ValidateModel(dto);

            // Assert
            Assert.Contains(validationResults, v => v.MemberNames.Contains(nameof(CreateUpdateCmsPageDto.HtmlContent)) && v.ErrorMessage.Contains("maximum length"));
        }

        private IList<ValidationResult> ValidateModel(object model)
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(model, null, null);
            Validator.TryValidateObject(model, validationContext, validationResults, true);
            return validationResults;
        }
    }
}