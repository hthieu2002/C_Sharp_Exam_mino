using Exam2;
using System;

namespace Exam2
{
    class Tester
    {
        static void Nhap1SV(Student sv)
        {
            Console.Write("Nhap MaSV: ");
            sv.SetStudentID(int.Parse(Console.ReadLine()));
            Console.Write("Ho ten SV: ");
            sv.SetName(Console.ReadLine());
            Console.Write("Nhap khoa: ");
            sv.SetFaculty(Console.ReadLine());
            Console.Write("Nhap Diem TB: ");
            sv.SetMark(float.Parse(Console.ReadLine()));
        }

        static void NhapDS(Student[] DSSV)
        {
            int n = DSSV.Length;
            Console.WriteLine("\n ====NHAP DS SINH VIEN====");
            for (int i = 0; i < n; i++)
            {
                DSSV[i] = new Student();
                Console.Write("Nhap thong tin cho sinh vien {0}:\n", i + 1);
                Nhap1SV(DSSV[i]);
            }
        }

        static void XuatDS(Student[] DSSV)
        {
            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            foreach (Student sv in DSSV)
                sv.Show();
        }

        static void Main()
        {
            int n;
            Console.Write("Nhap so luong SV: ");
            n = int.Parse(Console.ReadLine());
            Student[] DSSV = new Student[n];
            NhapDS(DSSV);
            XuatDS(DSSV);
            Console.ReadLine();
        }
    }
}
