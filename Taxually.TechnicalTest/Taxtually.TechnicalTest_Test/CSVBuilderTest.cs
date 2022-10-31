using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taxually.TechnicalTest;
using Taxually.TechnicalTest.Models;

namespace Taxtually.TechnicalTest_Test
{
    [TestClass]
    public class CSVBuilderTest
    {
        [TestMethod]
        public void SuccessfullyBuildCSV()
        {
            // Arrange
            var request = new VatRegistrationRequest();
            request.Country = new Country() { CountryName = "GB" };
            request.CompanyName = "Testcompany";
            request.CompanyId = "fdjk432fd";
            
            // Assert
            var fromCall = CSVBuilder.BuildCSV(request);

            // Act
            Assert.IsNotNull(fromCall);
        }
    }
}