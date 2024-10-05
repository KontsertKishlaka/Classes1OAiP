namespace Classes1OAiP.Entities;

public class BankAccount
{
    public decimal Balance { get; private set; }

    public void Deposit(decimal deposit) => Balance += deposit;

    public void Withdraw(decimal withdrawCount)
    {
        if (withdrawCount > Balance)
        {
            Console.WriteLine("Ошибка! Сумма вывода превышает текущий баланс.\n");
            return;
        }

        Balance -= withdrawCount;
    }

    public void Transfer(BankAccount toBankAccount, decimal transferCount)
    {
        if (toBankAccount == this)
        {
            Console.WriteLine("Ошибка! Невозможно перевести свои деньги на свой же баланс.");
            return;
        }

        if (transferCount > Balance)
        {
            Console.WriteLine("Ошибка! Недостаточно средств для перевода.");
            return;
        }

        Balance -= transferCount;
        toBankAccount.Deposit(transferCount);
    }
}