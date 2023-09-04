using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
     class Student
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;
        public Student() //Constructor mac dinh
        {
            SID = 1;
            TenSV = "Nguyen Van Nam";
            Khoa = "CNTT";
            DiemTB = 7;
        }
        public Student(Student stu) //Constructor sao chep
        {
            SID = stu.SID;
            TenSV = stu.TenSV;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }
        //Constructor tham so
        public Student(int id, string ten, string kh, float dtb)
        {
            SID = id;
            TenSV = ten;
            Khoa = kh;
            DiemTB = dtb;
        }
        //Cac Property cho tung thuoc tinh cua lop
        public int StudentID //Property dai dien cho thuoc tinh SID
        {
            get { return SID; } //Lay du lieu
            set { SID = value; } //Gan du lieu
        }
        public String Name
        {
            get { return TenSV; }
            set { TenSV = value; }
        }
        public String Faculty
        {
            get { return Khoa; }
            set { Khoa = value; }
        }
        public float Mark
        {
            get { return DiemTB; }
            set { DiemTB = value; }
        }
        //Phuong thuc hien thi du lieu
        public void Show()
        {
            Console.WriteLine("MSSV:{0}", this.SID);
            Console.WriteLine("Ten SV:{0}", this.TenSV);
            Console.WriteLine("Khoa:{0}", this.Khoa);
            Console.WriteLine("Diem TB:{0}", this.DiemTB);
        }
    }
}

