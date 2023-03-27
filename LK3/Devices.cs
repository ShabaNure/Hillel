using System;

namespace LK3
{
    public class Memory:Computer, IDev
    {
        Random rnd = new Random();
        private string[] _memory;
        public string[] Mem=> _memory;
        public Memory()
        {
            _memory = new string[] { "8Gb 2666GHz", "4Gb 2800GHz", "8Gb 2800GHz", "8Gb 1666GHz" };
        }
        public void Connect(){ foreach (string i in _memory) Console.WriteLine(i); }
        public void Eject() { _memory[rnd.Next(0, 3)] = "Empty"; }
        public void Disconnect() { for (int i = 0; i < _memory.Length; i++) _memory[i] = string.Empty; }
    }
    public class HDrive : Computer, IDev
    {
        Random rnd = new Random();
        private string[] _hDrive;
        public string[] HDr => _hDrive;
        public HDrive()
        {
            _hDrive = new string[] { "500Gb HDD", "1TB SSD" };
        }
        public void Connect() { foreach (string i in _hDrive) Console.WriteLine(i); }
        public void Remove() { _hDrive[rnd.Next(0, 1)] = "Empty"; }
        public void Disconnect() { for (int i = 0; i < _hDrive.Length; i++) _hDrive[i] = string.Empty; }

    }
    public class CPU : Computer,IDev
    {
        private string _processor;
        public string Processor { get { return _processor; } set { _processor = value; } }
        public CPU()
        {
            _processor = "Intel i5";
        }
        public void Connect() { Console.WriteLine(_processor); }
        public void Unplug() { _processor = "Empty"; }
        public void Disconnect() { _processor= string.Empty; }

    }
}
