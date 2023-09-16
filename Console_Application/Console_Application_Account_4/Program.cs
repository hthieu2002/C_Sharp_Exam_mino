using Console_Application_Account_4;
using System;

namespace Console_Application_Account_4
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountList accountList = new AccountList();

            while (true)
            {
                Console.WriteLine("Chọn một lệnh:");
                Console.WriteLine("1. Add - Thêm một account mới");
                Console.WriteLine("2. Save - Lưu danh sách account vào file");
                Console.WriteLine("3. Load - Đọc danh sách account từ file");
                Console.WriteLine("4. Remove - Xóa một account khỏi danh sách");
                Console.WriteLine("5. Sort - Sắp xếp danh sách account");
                Console.WriteLine("6. Report - Hiển thị thông tin các account");
                Console.WriteLine("7. Exit - Thoát chương trình");

                string choice = Console.ReadLine().ToLower();

                switch (choice)
                {
                    case "add":
                        accountList.NewAccount();
                        break;
                    case "save":
                        Console.Write("Input file name to save: ");
                        string saveFileName = Console.ReadLine();
                        accountList.SaveFile(saveFileName);
                        break;
                    case "load":
                        Console.Write("Input file name to load: ");
                        string loadFileName = Console.ReadLine();
                        accountList.LoadFile(loadFileName);
                        break;
                    case "remove":
                        Console.Write("Input Account ID to remove: ");
                        int accountIDToRemove = int.Parse(Console.ReadLine());
                        accountList.RemoveAccount(accountIDToRemove);
                        break;
                    case "sort":
                        accountList.SortAccounts();
                        break;
                    case "report":
                        Console.WriteLine("Danh sách các account:");
                        foreach (Account acc in accountList.GetAccounts())
                        {
                            acc.Query();
                            Console.WriteLine();
                        }
                        break;
                    case "exit":
                        Console.WriteLine("Chương trình kết thúc.");
                        return;
                    default:
                        Console.WriteLine("Lệnh không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
            }
        }
    }
}
