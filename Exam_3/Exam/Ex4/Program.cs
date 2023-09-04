using System;
using System.Collections.Generic;

class Person
{
    public string FullName { get; set; }
    public int BirthYear { get; set; }
    public string Degree { get; set; }
    public string Position { get; set; }
}

class Scientist : Person
{
    public int PublishedPapers { get; set; }
    public int WorkDaysPerMonth { get; set; }
    public int SalaryGrade { get; set; }

    public int CalculateSalary()
    {
        return WorkDaysPerMonth * SalaryGrade;
    }
}

class Manager : Person
{
    public int WorkDaysPerMonth { get; set; }
    public int SalaryGrade { get; set; }

    public int CalculateSalary()
    {
        return WorkDaysPerMonth * SalaryGrade;
    }
}

class LabEmployee : Person
{
    public int MonthlySalary { get; set; }
}

class Program
{
    static void Main()
    {
        List<Person> instituteStaff = new List<Person>();

        // Nhập thông tin các đối tượng
        Console.WriteLine("Nhập thông tin về nhân viên viện khoa học:");
        Scientist scientist1 = new Scientist
        {
            FullName = "Nguyen Van A",
            BirthYear = 1980,
            Degree = "Tiến sĩ",
            Position = "Giáo sư",
            PublishedPapers = 50,
            WorkDaysPerMonth = 20,
            SalaryGrade = 1000
        };
        instituteStaff.Add(scientist1);

        Console.WriteLine("Nhập thông tin về nhân viên quản lý:");
        Manager manager1 = new Manager
        {
            FullName = "Tran Thi B",
            BirthYear = 1975,
            Degree = "Thạc sĩ",
            Position = "Trưởng phòng",
            WorkDaysPerMonth = 22,
            SalaryGrade = 800
        };
        instituteStaff.Add(manager1);

        Console.WriteLine("Nhập thông tin về nhân viên phòng thí nghiệm:");
        LabEmployee labEmployee1 = new LabEmployee
        {
            FullName = "Hoang Van C",
            BirthYear = 1990,
            Degree = "Cử nhân",
            MonthlySalary = 600
        };
        instituteStaff.Add(labEmployee1);

        // Xuất thông tin và tổng lương cho từng loại đ
        Console.WriteLine("\nDanh sách nhân viên Viện Khoa học:");
        foreach (var person in instituteStaff)
        {
            Console.WriteLine($"Họ tên: {person.FullName}");
            Console.WriteLine($"Năm sinh: {person.BirthYear}");
            Console.WriteLine($"Bằng cấp: {person.Degree}");
            Console.WriteLine($"Chức vụ: {person.Position}");
            Console.WriteLine();

            if (person is Scientist scientist)
            {
                Console.WriteLine($"Số bài báo đã công bố: {scientist.PublishedPapers}");
                Console.WriteLine($"Số ngày công trong tháng: {scientist.WorkDaysPerMonth}");
                Console.WriteLine($"Tổng lương: {scientist.CalculateSalary()} VNĐ");
            }
            else if (person is Manager manager)
            {
                Console.WriteLine($"Số ngày công trong tháng: {manager.WorkDaysPerMonth}");
                Console.WriteLine($"Tổng lương: {manager.CalculateSalary()} VNĐ");
            }
            else if (person is LabEmployee labEmployee)
            {
                Console.WriteLine($"Lương trong tháng: {labEmployee.MonthlySalary} VNĐ");
            }

            Console.WriteLine("-----------------------------------------");
        }

        // Tính tổng lương đã chi trả cho từng loại đối tượng
        int totalScientistSalary = 0;
        int totalManagerSalary = 0;
        int totalLabEmployeeSalary = 0;

        foreach (var person in instituteStaff)
        {
            if (person is Scientist scientist)
            {
                totalScientistSalary += scientist.CalculateSalary();
            }
            else if (person is Manager manager)
            {
                totalManagerSalary += manager.CalculateSalary();
            }
            else if (person is LabEmployee labEmployee)
            {
                totalLabEmployeeSalary += labEmployee.MonthlySalary;
            }
        }

        Console.WriteLine($"Tổng lương của nhà khoa học: {totalScientistSalary} VNĐ");
        Console.WriteLine($"Tổng lương của nhà quản lý: {totalManagerSalary} VNĐ");
        Console.WriteLine($"Tổng lương của nhân viên phòng thí nghiệm: {totalLabEmployeeSalary} VNĐ");
    }
}
