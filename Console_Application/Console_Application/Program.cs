using System;

namespace Console_Application
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
                Console.WriteLine("4. Report - Hiển thị thông tin các account");
                Console.WriteLine("5. Exit - Thoát chương trình");

                string choice = Console.ReadLine().ToLower();

                switch (choice)
                {
                    case "add":
                        accountList.NewAccount();
                        break;
                    case "save":
                        accountList.SaveFile();
                        break;
                    case "load":
                        accountList.LoadFile();
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
