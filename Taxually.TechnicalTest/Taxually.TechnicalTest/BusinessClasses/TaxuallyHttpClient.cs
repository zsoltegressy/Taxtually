namespace Taxually.TechnicalTest
{
    public class TaxuallyHttpClient
    {
        // it is better to store the url inside the file or in a config file
        const string url = "https://api.uktax.gov.uk";

        public Task PostAsync<TRequest>(TRequest request)
        {
            // Actual HTTP call removed for purposes of this exercise
            return Task.CompletedTask;
        }
    }
}
