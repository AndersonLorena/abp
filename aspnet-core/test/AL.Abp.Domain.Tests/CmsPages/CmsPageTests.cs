using AL.Abp.Entities;
using Volo.Abp;
using Xunit;

namespace AL.Abp.CmsPages
{
    public class CmsPageTests
    {
        [Fact]
        public void Should_Create_Valid_CmsPage()
        {
            // Arrange
            var name = "Valid Name";
            var htmlContent = "<p>Valid Content</p>";

            // Act
            var cmsPage = new CmsPage(name, htmlContent);

            // Assert
            Assert.Equal(name, cmsPage.Name);
            Assert.Equal(htmlContent, cmsPage.HtmlContent);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("NewZelandCityName_TaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahu")]
        public void Should_Throw_Exception_If_Invalid_Name(string invalidName)
        {
            // Arrange
            var htmlContent = "<p>Valid Content</p>";

            // Act & Assert
            Assert.Throws<BusinessException>(() => new CmsPage(invalidName, htmlContent));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("NewZelandCityName_TaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahuTaumatawhakatangihangakoauauotamateaturipukakapikimaungahoronukupokaiwhenuakitnatahu")]
        public void Should_Throw_Exception_If_Invalid_HtmlContent(string invalidHtmlContent)
        {
            // Arrange
            var name = "Valid Name";

            // Act & Assert
            Assert.Throws<BusinessException>(() => new CmsPage(name, invalidHtmlContent));
        }
    }
}