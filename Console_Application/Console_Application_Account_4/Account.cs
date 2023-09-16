using System;
using System.Runtime.Serialization;

namespace Console_Application_Account_4
{
    [Serializable]
    public class Account
    {
        public int AccountID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Balance { get; set; }

        public Account(int accountID, string firstName, string lastName, double balance)
        {
            AccountID = accountID;
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
        }

        public void FillInfo()
        {
            Console.Write("Nhập Account ID: ");
            AccountID = int.Parse(Console.ReadLine());

            Console.Write("Nhập First Name: ");
            FirstName = Console.ReadLine();

            Console.Write("Nhập Last Name: ");
            LastName = Console.ReadLine();

            Console.Write("Nhập Balance: ");
            Balance = double.Parse(Console.ReadLine());
        }

        public void Query()
        {
            Console.WriteLine($"Account ID: {AccountID}");
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Balance: {Balance}");
        }
    }
}
