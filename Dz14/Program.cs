using System.Text;

namespace Dz14
{
    public class Account
    {
        private string name;
        private double balance;

        public Account(string name, double entrybalance)
        {
            Console.OutputEncoding = Encoding.UTF8;
            this.name = name;
            balance = entrybalance;

            if (entrybalance < 0)
            {
                throw new Exception("Початкова сума не може бути меншою за 0");
            }
            
        }

        public void Deposit(double amount)
        {
            Console.OutputEncoding = Encoding.UTF8;
            if (amount < 0)
            {
                Console.WriteLine("cума не може бути відємною");
                return;
            }
            balance += amount;
            Console.WriteLine($"На рахунок {name} додано {amount:C2}. Новий баланс: {balance:C2}");
        }

        public void Withdrawal(double amount)
        {
            Console.OutputEncoding = Encoding.UTF8;
            if (amount < 0)
            {
                Console.WriteLine("Сума не може бути відємною");
                return;
            }
            if (amount > balance)
            {
                Console.WriteLine("Недостатньо коштів");
                return;
            }
            balance -= amount;
            Console.WriteLine($"З рахунку {name} знято {amount:C2}. Новий баланс: {balance:C2}");
        }
        public double Balance
        {
            get
            {
                return balance;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Account heikkisAccount = new Account("Heikki's account", 100.00);
            Account heikkisSwissAccount = new Account("Heikki's account in Switzerland", 1000000.00);

            heikkisAccount.Withdrawal(20);
            Console.WriteLine($"Баланс рахунку Heikki зараз: {heikkisAccount.Balance:C2}");

            heikkisSwissAccount.Deposit(200);
            Console.WriteLine($"Баланс рахунку Heikki in Switzerland зараз: {heikkisSwissAccount.Balance:C2}");
        }
    }
}