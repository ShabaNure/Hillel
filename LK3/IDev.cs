namespace LK3
{
    public interface IDev
    {
        void Eject() { }
        void Remove() { }
        void Unplug() { }
        void Connect() { }
        void Disconnect() { Console.WriteLine("Device"); }

    }
}
