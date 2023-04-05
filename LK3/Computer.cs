using System;

namespace LK3
{
    public class Computer:IDisposable
    {
        public void AddDevice(IDev device)
        {
            if(device is IRam)
            {
                device.Eject();
            }
            else if(device is IHardDrive)
            {
                device.Remove();
            }
            else if (device is ICpu)
            {
                device.Unplug();
            }
            else
            {
                device.Disconnect();
            }

        }

        public void Disconnect()
        {
            Console.WriteLine("-----Nothing-----");
        }
        public void Dispose()
        {
            Console.WriteLine("-----All devices disconnected-----");
        }
    }
}
