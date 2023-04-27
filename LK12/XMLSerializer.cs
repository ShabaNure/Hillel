using System.Xml.Serialization;

namespace LK12
{
    public class XMLSerializer
    {
        private XmlSerializer xmlSerializer = new XmlSerializer(typeof(PowerPlant));

        public string SerializeXml(PowerPlant powerPlant)
        {
            var writer = new StringWriter();
            xmlSerializer.Serialize(writer, powerPlant);
            var xmlString = writer.ToString();

            Console.WriteLine(xmlString);
            return xmlString;
        }
        public PowerPlant DeserializeXml(string data)
        {
            var reader = new StringReader(data);
            var deserializeXml=(PowerPlant)xmlSerializer.Deserialize(reader);
            return deserializeXml;
        }
    }
}
