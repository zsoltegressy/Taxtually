using System.Text;
using Taxually.TechnicalTest.Models;

namespace Taxually.TechnicalTest
{
    public static class CSVBuilder
    {
        public static byte[] BuildCSV(VatRegistrationRequest registration)
        {
            var csvBuilder = new StringBuilder();
            csvBuilder.AppendLine("CompanyName,CompanyId");
            csvBuilder.AppendLine($"{registration.CompanyName}{registration.CompanyId}");
            return Encoding.UTF8.GetBytes(csvBuilder.ToString());
            
        }
    }
}
