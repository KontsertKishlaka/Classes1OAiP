using Classes1OAiP.Entities;

namespace Classes1OAiP;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("ЗАДАНИЕ №1\n\n"); // ЗАДАНИЕ №1

        var person1 = new Person("Полина", 19);
        var person2 = new Person("Влад", 22);

        person1.Greet();
        person2.Greet();



        Console.WriteLine("\n\nЗАДАНИЕ №2\n\n"); // ЗАДАНИЕ №2

        var rectangle = new Rectangle(10, 5);

        Console.WriteLine($"Площадь прямоугольника: {rectangle.Area()}");
        Console.WriteLine($"Периметр прямоугольника: {rectangle.Perimeter()}");



        Console.WriteLine("\n\nЗАДАНИЕ №3\n\n"); // ЗАДАНИЕ №3

        var bankAccount1 = new BankAccount();
        var bankAccount2 = new BankAccount();

        bankAccount1.Deposit(1000);
        bankAccount2.Deposit(1250);

        bankAccount2.Withdraw(50);

        bankAccount1.Transfer(bankAccount1, 300); // Ошибка: Невозможно перевести свои деньги на свой же баланс
        bankAccount1.Transfer(bankAccount2, 10000); // Ошибка: Недостаточно средств для перевода
        bankAccount1.Transfer(bankAccount2, 300); 

        Console.WriteLine(
            $"Баланс 1-ого банковского аккаунта: {bankAccount1.Balance}\n" +
            $"Баланс 2-ого банковского аккаунта: {bankAccount2.Balance}\n");
    }
}