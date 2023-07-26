using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppInheritancesAssignment16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter Account Holder Name");
                    string accountHolderName = Console.ReadLine();
                    BankAccount account = new BankAccount(accountHolderName);
                    Console.WriteLine($"Account Number: {account.AccountNumber}");
                    Console.WriteLine($"Account Holder Name: {account.AccountHolderName}");
                    Console.WriteLine($"Account Balance: {account.GetBalance()}");

                    Console.WriteLine("Enter the amount to be deposited");
                    double depositAmount = double.Parse(Console.ReadLine());
                    account.Deposit(depositAmount);
                    Console.WriteLine($"Balance after deposit: {account.GetBalance()}");

                    Console.WriteLine("Enter the amount to be withdrwan");
                    double withdrawAmount = double.Parse(Console.ReadLine());
                    account.Withdraw(withdrawAmount);
                    Console.WriteLine($"Balance after withdrawl: {account.GetBalance()}");

                    Console.WriteLine("Do you want to continue? (Y/N)");
                    string response = Console.ReadLine().ToUpper();
                    if (response != "Y")
                    {
                        break;
                    }
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}














//using System;
//public class BankAccount
//{
//    private static int accountCounter = 1000;
//    public int AccountNumber { get; }
//    public string AccountHolderName { get; }
//    private double Balance { get; set; }

//    public BankAccount(string accountHolderName)
//    {
//        AccountNumber = GenerateAccountNumber();
//        AccountHolderName = accountHolderName;
//        Balance = 0;
//    }

//    private static int GenerateAccountNumber()
//    {
//        return ++accountCounter;
//    }

//    public void Deposit(double amount)
//    {
//        if (amount <= 0)
//        {
//            throw new ArgumentException("Deposit amount must be greater than zero.");
//        }

//        Balance += amount;
//    }
//    public void Withdraw(double amount)
//    {
//        if (amount <= 0)
//        {
//            throw new ArgumentException("Withdrawal amount must be greater than zero.");
//        }

//        if (amount > Balance)
//        {
//            throw new InvalidOperationException("Insufficient funds.");
//        }

//        Balance -= amount;
//    }
//    public double GetBalance()
//    {
//        return Balance;
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Console.Write("Enter account holder's name: ");
//        string accountHolderName = Console.ReadLine();

//        BankAccount account = new BankAccount(accountHolderName);

//        Console.Write("Enter amount to deposit: ");
//        double depositAmount = Convert.ToDouble(Console.ReadLine());

//        try
//        {
//            account.Deposit(depositAmount);
//            Console.WriteLine("Account Holder: " + account.AccountHolderName);
//            Console.WriteLine("Account Number: " + account.AccountNumber);
//            Console.WriteLine("Balance after deposit: Rs" + account.GetBalance());

//            Console.Write("Enter amount to withdraw: ");
//            double withdrawalAmount = Convert.ToDouble(Console.ReadLine());

//            try
//            {
//                account.Withdraw(withdrawalAmount);
//                Console.WriteLine("Balance after withdrawal: Rs" + account.GetBalance());
//            }
//            catch (ArgumentException ex)
//            {
//                Console.WriteLine("Error: " + ex.Message);
//            }
//            catch (InvalidOperationException ex)
//            {
//                Console.WriteLine("Error: " + ex.Message);
//            }
//        }
//        catch (ArgumentException ex)
//        {
//            Console.WriteLine("Error: " + ex.Message);
//        }
//    }
//}