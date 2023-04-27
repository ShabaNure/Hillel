namespace LK12
{
    [Serializable]
    public class PowerPlant
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }

        private string _location;
        public string Location { get { return _location; } set { _location = value; } }


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
