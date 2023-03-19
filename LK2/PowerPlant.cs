namespace LK2
{
    internal class PowerPlant
    {
        private readonly string _name;
        public string Name => _name;
        private readonly string _location;
        public string Location => _location;


        public PowerPlant() 
        {
            _name= string.Empty;
            _location= string.Empty;
        }
        public PowerPlant(string name, string location)
        {
            _name = name;
            _location = location;
        }
        public virtual void Print()
        {
            string _out =
                "-----------------------------------------\n" +
                $"Power plant name - {Name}\n" +
                $"Power plant location - {Location}\n" +
                "-----------------------------------------";
            Console.WriteLine(_out);
        }

    }
}
