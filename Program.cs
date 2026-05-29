using System.Xml.Linq;

XDocument doc = XDocument.Load("users.xml");

foreach (var user in doc.Descendants("User"))
{
    Console.WriteLine($"Name: {user.Element("Name")?.Value}");
    Console.WriteLine($"Age: {user.Element("Age")?.Value}");
    Console.WriteLine($"City: {user.Element("City")?.Value}");
    Console.WriteLine();
}