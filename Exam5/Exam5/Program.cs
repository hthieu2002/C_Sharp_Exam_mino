using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhập vào một chuỗi số, cách nhau bởi dấu cách:");
        string input = Console.ReadLine(); // Đọc chuỗi từ bàn phím
        int[] numbers = input.Split(' ').Select(int.Parse).ToArray(); // Chuyển chuỗi thành mảng số nguyên
        int product = 1; // Khởi tạo biến tích bằng 1
        for (int i = 0; i < numbers.Length; i++) // Duyệt qua từng số trong mảng
        {
            if (i % 2 == 0) // Nếu vị trí của số đó là vị trí chẵn
            {
                product *= numbers[i]; // Nhân tích với số đó
            }
        }
        Console.WriteLine("Kết quả là: " + product); // In ra kết quả
    }
}
