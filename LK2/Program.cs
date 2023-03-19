namespace LK2
{
    internal class Program
    {
        static void Main()
        {
            PowerPlant plant1= new PowerPlant("Zaporozhye NPP", "Zaporozhye");
            Block[] block = new Block[3];
            block[0] = new Block(1, true, 213, 43);
            block[1] = new Block(2, false, 200, 38);
            block[2] = new Block(3, true, 280, 47);
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
                    $"Reactor number - {block[i].ReactorNumber}\n" +
                    $"Reactor status - {stat}\n"+
                    $"Reactor power - {block[i].ReactorPower}\n"+
                    $"Count of workers - {block[i].CountOfPersons}";
                Console.WriteLine(inf);
                draw.PlantInfo();
            }
            
        }
    }
}
