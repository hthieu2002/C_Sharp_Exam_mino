using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Nhập vào một danh sách các số nguyên, cách nhau bởi dấu cách
        Console.WriteLine("Nhập vào một danh sách các số nguyên, cách nhau bởi dấu cách:");
        string input = Console.ReadLine();

        // Chuyển đổi chuỗi thành mảng các số nguyên
        int[] numbers = input.Split().Select(int.Parse).ToArray();

        // Tạo một danh sách để lưu kết quả
        List<int> result = new List<int>();

        // Lặp cho đến khi số đầu không vượt quá số cuối
        for (int i = 0; i < numbers.Length / 2; i++)
        {
            int currentSum = numbers[i] + numbers[numbers.Length - 1 - i];
            result.Add(currentSum);
        }

        // Nếu danh sách có độ dài lẻ, thêm số ở giữa vào kết quả
        if (numbers.Length % 2 == 1)
        {
            result.Add(numbers[numbers.Length / 2]);
        }

        // In ra kết quả, cách nhau bởi dấu cách
        Console.WriteLine("Kết quả là:");
        Console.WriteLine(string.Join(" ", result));
    }
}
