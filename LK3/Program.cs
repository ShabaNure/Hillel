namespace LK3
{
    internal class Program
    {
        static void Main()
        {
            
            var ram = new Ram();
            var hard = new HardDrive();
            var cpu = new Cpu();

            using (var pc = new Computer())
            {
                pc.AddDevice(ram);
                pc.AddDevice(hard);
                pc.AddDevice(cpu);
            }
        }
    }
}
