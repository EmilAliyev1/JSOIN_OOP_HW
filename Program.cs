using Newtonsoft.Json;

string json = File.ReadAllText("users.json");

List<User> users = JsonConvert.DeserializeObject<List<User>>(json);

foreach (User user in users)
{
    Console.WriteLine($"Name: {user.Name}");
    Console.WriteLine($"Age: {user.Age}");
    Console.WriteLine($"City: {user.City}");
    Console.WriteLine();
}