// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
public class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var person = new Person { Name = "John", Age = 30 };
        string jsonString = JsonConvert.SerializeObject(person);
        Console.WriteLine(jsonString);
    }
}