using System.Collections;
using System;
using System.Collections;
using System.IO;
using Newtonsoft.Json;
using System.Xml;

namespace Console_Application_Account_4
{
    public class AccountList
    {
        private ArrayList accounts = new ArrayList();

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

        public void SaveFile(string filename)
        {
            try
            {
                string json = JsonConvert.SerializeObject(accounts, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(filename, json);
                Console.WriteLine("Danh sách account đã được lưu trữ bằng JSON.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void LoadFile(string filename)
        {
            try
            {
                string json = File.ReadAllText(filename);
                accounts = JsonConvert.DeserializeObject<ArrayList>(json);
                Console.WriteLine("Danh sách account đã được đọc từ file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void RemoveAccount(int accountID)
        {
            int index = accounts.BinarySearch(new Account(accountID, "", "", 0), new AccountComparer());
            if (index >= 0)
            {
                accounts.RemoveAt(index);
                Console.WriteLine("Account đã được xóa khỏi danh sách.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy account với Account ID này.");
            }
        }

        public void SortAccounts()
        {
            accounts.Sort(new AccountComparer());
            Console.WriteLine("Danh sách account đã được sắp xếp.");
        }
    }
}
