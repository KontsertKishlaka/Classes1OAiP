namespace Classes1OAiP.Entities;

public class Person(string name, int age)
{
    public string? Name { get; private set; } = name;
    public int Age { get; private set; } = age;

    public void Greet() => Console.WriteLine($"Привет! Меня зовут {Name} и мне {Age} лет.");
}