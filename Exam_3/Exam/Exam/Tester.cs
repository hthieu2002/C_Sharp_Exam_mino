using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
     class Tester
    {
        public static void Main()
        {
            Student[] DSSV;
            int n;
            Console.Write("Nhap so luong SV:");
            n = int.Parse(Console.ReadLine());
            DSSV = new Student[n]; //tao mang n phan tu
            Console.WriteLine("\n ====NHAP DS SINH VIEN====");
            for (int i = 0; i < n; i++) //Lap n lan nhap thong tin sv
            {
                DSSV[i] = new Student();
                Console.Write("Nhap MaSV {0}:", i + 1);
                DSSV[i].StudentID = int.Parse(Console.ReadLine());
                Console.Write("Ho ten SV:");
                DSSV[i].Name = Console.ReadLine();
                Console.Write("Nhap khoa:");
                DSSV[i].Faculty = Console.ReadLine();
                Console.Write("Nhap Diem TB:");
                DSSV[i].Mark = float.Parse(Console.ReadLine());
            }
            //Xuat DS Sinh vien
            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            foreach (Student sv in DSSV)
                sv.Show();
            Console.ReadLine();
        }
    }
}
