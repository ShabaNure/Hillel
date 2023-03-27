namespace LK3
{
    internal class Program
    {
        static void Main()
        {
            var mem = new Memory();
            var hdrive = new HDrive();
            var cpu = new CPU();
            var temp = new Computer();
            using (var pc = new Computer(mem,hdrive,cpu))
            {
                pc.Menu(mem, hdrive, cpu,temp);
                pc.Disconnect(mem, hdrive, cpu);
            }
        }
    }
}
