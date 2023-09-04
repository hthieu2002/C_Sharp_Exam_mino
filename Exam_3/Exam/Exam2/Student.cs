using System;

namespace Exam2
{
    class Student
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;

        public Student()
        {
            SID = 1;
            TenSV = "Nguyen Van A";
            Khoa = "CNTT";
            DiemTB = 7;
        }

        public Student(Student stu)
        {
            SID = stu.GetStudentID();
            TenSV = stu.GetName();
            Khoa = stu.GetFaculty();
            DiemTB = stu.GetMark();
        }

        public Student(int id, string ten, string kh, float dtb)
        {
            SID = id;
            TenSV = ten;
            Khoa = kh;
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

        public string GetName()
        {
            return TenSV;
        }

        public void SetName(string ten)
        {
            TenSV = ten;
        }

        public string GetFaculty()
        {
            return Khoa;
        }

        public void SetFaculty(string kh)
        {
            Khoa = kh;
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
            Console.WriteLine("MSSV:{0}", this.GetStudentID());
            Console.WriteLine("Ten SV:{0}", this.GetName());
            Console.WriteLine("Khoa:{0}", this.GetFaculty());
            Console.WriteLine("Diem TB:{0}", this.GetMark());
        }
    }
}
