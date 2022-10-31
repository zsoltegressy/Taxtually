using Taxually.TechnicalTest.Models;

namespace Taxually.TechnicalTest
{
    public class TaxuallyQueueClient
    {
        // it is better to store the filename inside the class or in a config file
        const string CSVQueueName = "vat-registration-csv";
        const string XMLQueueName = "vat-registration-xml";

        public Task EnqueueAsync(bool isCsv, VatRegistrationRequest payload)
        {
            if (isCsv)
            {
                // France requires an excel spreadsheet to be uploaded to register for a VAT number
                var csv = CSVBuilder.BuildCSV(payload);
            }
            else
            {
                var xml = XMLBuilder.BuildXML(payload);
            }

            // Code to send to message queue removed for brevity
            return Task.CompletedTask;
        }
    }
}
