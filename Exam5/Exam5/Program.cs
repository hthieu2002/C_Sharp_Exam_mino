using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Nhập vào một danh sách các số thập phân, cách nhau bởi dấu cách
        Console.WriteLine("Nhập vào một danh sách các số thập phân, cách nhau bởi dấu cách:");
        string input = Console.ReadLine();

        // Chuyển đổi chuỗi thành một mảng các số thập phân
        decimal[] numbers = input.Split().Select(decimal.Parse).ToArray();

        // Tạo một danh sách để lưu kết quả
        List<decimal> result = new List<decimal>();

        // Duyệt qua mảng các số thập phân từ trái sang phải
        for (int i = 0; i < numbers.Length; i++)
        {
            // Lấy số hiện tại
            decimal current = numbers[i];

            // Nếu số hiện tại bằng số kế tiếp, thì cộng chúng lại
            while (i < numbers.Length - 1 && current == numbers[i + 1])
            {
                current += numbers[i + 1];
                i++;
            }

            // Thêm số hiện tại vào danh sách kết quả
            result.Add(current);
        }

        // In ra kết quả, cách nhau bởi dấu cách
        Console.WriteLine("Kết quả là:");
        Console.WriteLine(string.Join(" ", result));
    }
}
