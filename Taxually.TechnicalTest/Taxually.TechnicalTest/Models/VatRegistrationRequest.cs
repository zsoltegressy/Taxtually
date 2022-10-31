namespace Taxually.TechnicalTest.Models
{
    public class VatRegistrationRequest
    {
        public string CompanyId { get; set; }
        public string CompanyName { get; set; }
        public Country Country { get; set; }
    }
}
