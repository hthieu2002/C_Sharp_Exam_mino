using System;
using System.Collections.Generic;
using System.Linq;

// Định nghĩa lớp Student
class Student
{
    // Khai báo các thuộc tính ID, Name và Age kiểu int, string và int
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    // Khởi tạo lớp Student với ba tham số id, name và age
    public Student(int id, string name, int age)
    {
        ID = id;
        Name = name;
        Age = age;
    }

    // Ghi đè phương thức ToString để trả về chuỗi biểu diễn thông tin của sinh viên
    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Age: {Age}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tạo một danh sách các sinh viên
        List<Student> students = new List<Student>();

        // Thêm vào danh sách một số sinh viên mẫu
        students.Add(new Student(1, "An", 20));
        students.Add(new Student(2, "Binh", 19));
        students.Add(new Student(3, "Chau", 21));
        students.Add(new Student(4, "Dung", 18));
        students.Add(new Student(5, "Eva", 22));

        // Sắp xếp danh sách theo Name bằng phương thức OrderBy của LINQ
        students = students.OrderBy(s => s.Name).ToList();

        // In ra màn hình danh sách các sinh viên sau khi sắp xếp
        Console.WriteLine("Danh sách các sinh viên sau khi sắp xếp theo Name:");
        foreach (Student s in students)
        {
            Console.WriteLine(s);
        }
    }
}
