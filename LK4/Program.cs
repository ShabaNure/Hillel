using System;

namespace LK4
{
    internal class Program
    {
        static void Main()
        {
            var lst = new DatabaseEngine<string, string>.DatabaseValue();
            var data = new DatabaseEngine<string, string>();
            string tempName;
            for(int i = 0; i < 10; i++) 
            {
                string name = "Name" + i;
                string password = PasswordGenerator.Generate();
                data.WriteValue(lst.Value, name,password);
                lst.TableName[i] = name;
                Console.WriteLine(name);
            }
            Console.WriteLine("Выберите имя");
            tempName= Console.ReadLine();

            data.ReadValue(tempName);
            lst.Value[tempName];
        }
    }
}
