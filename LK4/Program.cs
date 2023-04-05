using LK4;

var data = new DatabaseEngine<string, string>();

for (int i = 0; i < 10; i++)
{
    string name = "Name" + i;
    string key = "Key" + i;

    string password = PasswordGenerator.Generate();
    data.WriteValue(key, name, password);
}

Console.WriteLine("Выберите ключ 1 - 10");
var inputKey = Console.ReadLine();

data.ReadValue(inputKey);
