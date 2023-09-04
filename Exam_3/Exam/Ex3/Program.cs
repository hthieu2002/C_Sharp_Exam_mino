using System;
using System.Collections.Generic;

namespace Ex3
{
    class People
    {
        private string Ten;
        private string Khoa;

        public People()
        {
            Ten = "Nguyen Van A";
            Khoa = "CNTT";
        }

        public People(string ten, string kh)
        {
            Ten = ten;
            Khoa = kh;
        }

        public string GetName()
        {
            return Ten;
        }

        public void SetName(string ten)
        {
            Ten = ten;
        }

        public string GetFaculty()
        {
            return Khoa;
        }

        public void SetFaculty(string kh)
        {
            Khoa = kh;
        }
    }

    class Student : People
    {
        private int SID;
        private float DiemTB;

        public Student() : base()
        {
            SID = 1;
            DiemTB = 7;
        }

        public Student(int id, string ten, string kh, float dtb) : base(ten, kh)
        {
            SID = id;
            DiemTB = dtb;
        }

        public int GetStudentID()
        {
            return SID;
        }

        public void SetStudentID(int id)
        {
            SID = id;
        }

        public float GetMark()
        {
            return DiemTB;
        }

        public void SetMark(float dtb)
        {
            DiemTB = dtb;
        }

        public void Show()
        {
            Console.WriteLine("MSSV: {0}", this.GetStudentID());
            Console.WriteLine("Ten SV: {0}", this.GetName());
            Console.WriteLine("Khoa: {0}", this.GetFaculty());
            Console.WriteLine("Diem TB: {0}", this.GetMark());
        }
    }

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

        static void NhapDS(List<Student> DSSV)
        {
            Console.Write("Nhap so luong SV: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n ====NHAP DS SINH VIEN====");
            for (int i = 0; i < n; i++)
            {
                Student sv = new Student();
                Console.Write("Nhap thong tin cho sinh vien {0}:\n", i + 1);
                Nhap1SV(sv);
                DSSV.Add(sv);
            }
        }

        static void XuatDS(List<Student> DSSV)
        {
            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            foreach (Student sv in DSSV)
                sv.Show();
        }

        static void Main()
        {
            List<Student> DSSV = new List<Student>();
            NhapDS(DSSV);
            XuatDS(DSSV);
            Console.ReadLine(); // Kết thúc chương trình sau khi xuất dữ liệu
        }
    }
}
