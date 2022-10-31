using System.Xml.Serialization;
using Taxually.TechnicalTest.Models;

namespace Taxually.TechnicalTest
{
    public static class XMLBuilder
    {
        public static string BuildXML(VatRegistrationRequest registration)
        {
            // Germany requires an XML document to be uploaded to register for a VAT number
            using (var stringwriter = new StringWriter())
            {
                var serializer = new XmlSerializer(typeof(VatRegistrationRequest));
                serializer.Serialize(stringwriter, registration);
                var xml = stringwriter.ToString();
                return xml;
            }
        }
    }
}
