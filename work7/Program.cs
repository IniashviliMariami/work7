using System.Xml.Linq;

namespace work7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("davaleba 1");
            Console.WriteLine();

            Person firstPerson = new Person("mari", "iniashvili", 34, "01010101330", "599445566", "m@gmail.com");


            Console.WriteLine($"Name: {firstPerson.Name} {firstPerson.Lastname}");
            Console.WriteLine($"Age: {firstPerson.Age}");
            Console.WriteLine($"ID: {firstPerson.Id}");
            Console.WriteLine($"Phone number: {firstPerson.Phone}");
            Console.WriteLine($"Mail: {firstPerson.Mail}");

            Console.WriteLine();
            Console.WriteLine("davaleba meore");
            Console.WriteLine();


            Account firstAccount = new Account("1111111111111111111111", "USD", 500);
            Client firstClient = new Client("Mari", "Iniashvili", "01010101010", firstAccount);

            Account secondAccount = new Account("1111111111111111111111", "USD", 800);
            Client secondClient = new Client("nino", "Iniashvili", "01010101010", secondAccount);



            firstAccount.CashingOut(200);
            Console.WriteLine($"cashing out: {firstClient.Account.Balance}");

            firstAccount.ReplenishmentOfTheBalance(300);
            Console.WriteLine($"Replenishment of the balance: {firstAccount.Balance}");

            firstAccount.Transfer(secondAccount,200 );
            Console.WriteLine($"First/after: {firstAccount.Balance}");
            Console.WriteLine($"Second/after: {secondAccount.Balance}");











        }
    }
}
