using System;

namespace Console_Application
{
    public class Account
    {
        public int AccountID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Balance { get; set; }

        // Constructor
        public Account(int accountID, string firstName, string lastName, double balance)
        {
            AccountID = accountID;
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
        }

        // Phương thức để nhập thông tin từ bàn phím
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

        // Phương thức để hiển thị thông tin tài khoản
        public void Query()
        {
            Console.WriteLine($"Account ID: {AccountID}");
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Balance: {Balance}");
        }
    }
}
