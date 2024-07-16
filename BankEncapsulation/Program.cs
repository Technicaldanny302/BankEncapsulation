namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var DansAccount = new bankAccount();

            Console.WriteLine("How much would you like to deposit?");

            var amountToDeposit = double.Parse(Console.ReadLine());

            DansAccount.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you! your balance is now {DansAccount.GetBalance()}");
        }
    }
}
