using System;
using System.Collections;
using System.IO;

namespace Console_Application
{
    public class AccountList
    {
        private ArrayList accounts = new ArrayList();

        // Phương thức để tạo mới tài khoản và thêm vào danh sách
        public void NewAccount()
        {
            Account account = new Account(0, "", "", 0);
            account.FillInfo();
            accounts.Add(account);
        }

        public ArrayList GetAccounts()
        {
            return accounts;
        }

        // Phương thức để lưu danh sách account vào file
        public void SaveFile()
        {
            // Nhập tên file
            Console.Write("Input file name to save: ");
            string filename = Console.ReadLine();

            try
            {
                // Tạo luồng truy cập file
                using (FileStream output = new FileStream(filename, FileMode.Create, FileAccess.Write))
                using (StreamWriter writer = new StreamWriter(output))
                {
                    // Duyệt qua từng đối tượng trong danh sách account
                    foreach (Account acc in accounts)
                    {
                        // Ghi các thông tin của mỗi account trên một dòng, phân cách bằng dấu ','
                        writer.WriteLine("{0},{1},{2},{3}", acc.AccountID, acc.FirstName, acc.LastName, acc.Balance);
                    }
                }
                Console.WriteLine("Danh sách account đã được lưu vào file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Phương thức để đọc danh sách account từ file
        public void LoadFile()
        {
            // Đọc tên file chứa dữ liệu
            Console.Write("Input file name to load: ");
            string filename = Console.ReadLine();
            // Xóa danh sách hiện tại
            accounts.Clear();
            try
            {
                // Tạo luồng đọc file
                using (FileStream input = new FileStream(filename, FileMode.Open, FileAccess.Read))
                using (StreamReader reader = new StreamReader(input))
                {
                    string str;
                    // Đọc từng dòng cho đến khi gặp chuỗi null
                    while ((str = reader.ReadLine()) != null)
                    {
                        // Tách chuỗi đọc thành các chuỗi con bằng dấu ','
                        string[] list = str.Split(',');

                        // Tạo đối tượng Account mới
                        if (list.Length == 4)
                        {
                            Account acc = new Account(int.Parse(list[0]), list[1], list[2], double.Parse(list[3]));
                            accounts.Add(acc);
                        }
                    }
                }
                Console.WriteLine("Danh sách account đã được đọc từ file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
