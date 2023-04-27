namespace LK12
{
    [Serializable]
    public class Block:PowerPlant
    {
        private int _reactorNumber;
        public int ReactorNumber => _reactorNumber;
        private bool _reactorStatus;
        public bool ReactorStatus => _reactorStatus;
        private int _reactorPower;
        public int ReactorPower=> _reactorPower;
        private int _countOfPersons;
        public int CountOfPersons => _countOfPersons;

        public Block()
        {
            _reactorNumber = 0;
            _reactorStatus = false;
            _reactorPower = 0;
            _countOfPersons = 0;
        }
        public Block(int reactorNumber, bool reactorStatus, int reactorPower, int countOfPersons)
        {
            _reactorNumber = reactorNumber;
            _reactorStatus = reactorStatus;
            _reactorPower = reactorPower;
            _countOfPersons = countOfPersons;
        }
    }
}
