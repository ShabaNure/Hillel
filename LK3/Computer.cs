using System;

namespace LK3
{
    public class Computer:IDisposable
    {
        private List<IRam> rams= new List<IRam>();
        private List<IHardDrive> hardDrives = new List<IHardDrive>(); 
        private List<ICpu> cpus= new List<ICpu>();
        public void AddDevice(IDev device)
        {
            if(device is IRam)
            {
                rams.Add((IRam)device);
            }
            else if(device is IHardDrive)
            {
                hardDrives.Add((IHardDrive)device);
            }
            else if (device is ICpu)
            {
                cpus.Add((ICpu)device);
            }

        }

        public void Disconnect()
        {
            foreach (IRam device in rams) { device.Eject(); }
            foreach (IHardDrive device in hardDrives) { device.Remove(); }
            foreach (ICpu device in cpus) { device.Unplug();}
            Console.WriteLine("-------All devices disconnected------");
        }
        public void Dispose()
        {
            Disconnect();
        }
    }
}
