using Newtonsoft.Json;

string json = File.ReadAllText("userTypes.json");

UserTypes data = JsonConvert.DeserializeObject<UserTypes>(json);

Console.WriteLine("=== ADMINS ===");

foreach (Admin admin in data.Admins)
{
    Console.WriteLine($"{admin.Name} | {admin.PermissionLevel}");
}

Console.WriteLine();

Console.WriteLine("=== USERS ===");

foreach (RegularUser user in data.Users)
{
    Console.WriteLine($"{user.Name} | {user.MembershipType}");
}