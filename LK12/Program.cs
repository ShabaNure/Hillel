using System.Runtime.Serialization.Json;

namespace LK12
{
    internal class Program
    {
        static void Main()
        {
            List<Block> blockListSer = new List<Block>();
            List<Block> blockListDes = new List<Block>();

            PowerPlant plant1= new PowerPlant("Zaporozhye NPP", "Zaporozhye");
            var xmlSerializer = new XMLSerializer();
            var data = xmlSerializer.SerializeXml(plant1);
            var desdata=xmlSerializer.DeserializeXml(data);

            Block[] block = new Block[3];
            block[0] = new Block(1, true, 213, 43);
            block[1] = new Block(2, false, 200, 38);
            block[2] = new Block(3, true, 280, 47);

            blockListSer.Add(block[0]);
            blockListSer.Add(block[1]);
            blockListSer.Add(block[2]);

            SerializeJson("data.json", blockListSer);


            try
            {
                var dataList = DeserializeJson<Block>("data.json", typeof(List<Block>));
                blockListDes = dataList.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Draw draw = new DrawM();
            plant1.Print();
            string inf = "";
            string stat = "";
            for(int i = 0;i<3;i++) 
            {
                if (block[i].ReactorStatus==true)
                {
                    stat = "Enable";
                } else { stat = "Disable"; }
                inf = 
                    $"Reactor number - {blockListDes[i].ReactorNumber}\n" +
                    $"Reactor status - {stat}\n"+
                    $"Reactor power - {blockListDes[i].ReactorPower}\n"+
                    $"Count of workers - {blockListDes[i].CountOfPersons}";
                Console.WriteLine(inf);
                draw.PlantInfo();
            }
            
        }

        private static void SerializeJson<T>(string jsonFile, IEnumerable<T> data)
        {
            File.Delete("data.json");
            var serializer = new DataContractJsonSerializer(data.GetType());
            using (var file = new FileStream(jsonFile, FileMode.OpenOrCreate))
            {
                serializer.WriteObject(file, data);
            }
        }
        private static IEnumerable<T> DeserializeJson<T>(string jsonFile, Type type)
        {
            if (!File.Exists(jsonFile))
                return null;
            var json = new DataContractJsonSerializer(type);
            using (var file = new FileStream(jsonFile, FileMode.OpenOrCreate))
            {
                return json.ReadObject(file) as List<T>;
            }
        }
    }
}
