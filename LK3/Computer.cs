using System;

namespace LK3
{
    public class Computer:IDisposable
    {
        Random rnd= new Random();
        private string _newDevice;
        public string NewDevice { get { return _newDevice; } set { _newDevice = value; } }
        public Computer() {}
        public Computer(IDev dev1, IDev dev2, IDev dev3) 
        {
            dev1.Connect();
            dev2.Connect();
            dev3.Connect();
        }
        public void Menu(Memory mem, HDrive hDrive, CPU cpu, Computer temp)
        {
            Console.WriteLine("1 - Modification\n2 - Utilities\n3 - Exit");
            string sw = Console.ReadLine();
            switch(int.Parse(sw))
            {
                case 1:
                    {
                        Console.WriteLine("1 - New memory\n2 - New hard drive\n3 - New CPU");
                        sw = Console.ReadLine();
                        switch (int.Parse(sw))
                        {
                            case 1:
                                {
                                    temp = new Memory();
                                    break;
                                }
                            case 2: 
                                {
                                    temp = new HDrive();
                                    break;
                                }
                            case 3:
                                {
                                    temp = new CPU();
                                    break;
                                }
                            default: Console.WriteLine("Try again"); Menu(mem, hDrive, cpu, temp); break;
                        }
                        temp.NewDevice = Console.ReadLine();
                        if (temp is Memory)
                        {
                            mem.Mem[rnd.Next(0, 3)] = temp.NewDevice;
                        }
                        else if(temp is HDrive) 
                        {
                            hDrive.HDr[rnd.Next(0, 1)] = temp.NewDevice;
                        }
                        else if(temp is CPU)
                        {
                            cpu.Processor = temp.NewDevice;
                        }

                        Console.WriteLine("--------Changed---------");
                        mem.Connect();
                        hDrive.Connect();
                        cpu.Connect();
                        Menu(mem, hDrive, cpu, temp);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Use utilities\n1 - Memory utility\n2 - Hard drive utility\n3 - CPU utility");
                        sw = Console.ReadLine();
                        switch (int.Parse(sw))
                        {
                            case 1:
                                {
                                    mem.Eject();
                                    break;
                                }
                            case 2:
                                {
                                    hDrive.Remove();
                                    break;
                                }
                            case 3:
                                {
                                    cpu.Unplug();
                                    break;
                                }
                            default: Console.WriteLine("Try again"); Menu(mem, hDrive, cpu, temp); break;
                        }
                        Console.WriteLine("--------Changed---------");
                        mem.Connect();
                        hDrive.Connect();
                        cpu.Connect();
                        Menu(mem, hDrive, cpu, temp);
                        break; 
                    }
                case 3: break;
                default: Console.WriteLine("Try again"); Menu(mem, hDrive, cpu, temp);break;

            }
            
        }
        public void Disconnect(Memory mem, HDrive hDrive, CPU cpu)
        {
            mem.Disconnect();
            hDrive.Disconnect();
            cpu.Disconnect();
        }
        public void Dispose()
        {
            Console.WriteLine("-----All devices disconnected-----");
        }
    }
}
