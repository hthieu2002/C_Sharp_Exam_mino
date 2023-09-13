using System;

// Khai báo không gian tên Car
namespace ElectricCarExample
{
    // Khai báo giao diện ICar
    public interface ICar
    {
        // Khai báo thuộc tính Model kiểu string
        string Model { get; set; }

        // Khai báo thuộc tính Color kiểu string
        string Color { get; set; }

        // Khai báo phương thức Start kiểu string
        string Start();

        // Khai báo phương thức Stop kiểu string
        string Stop();

        // Khai báo phương thức ToString kiểu string
        string ToString();
    }

    // Khai báo lớp ElectricCar thực thi giao diện ICar
    public class ElectricCar : ICar
    {
        // Khai báo và triển khai thuộc tính Model kiểu string
        public string Model { get; set; }

        // Khai báo và triển khai thuộc tính Color kiểu string
        public string Color { get; set; }

        // Khởi tạo lớp ElectricCar với hai tham số model và color
        public ElectricCar(string model, string color)
        {
            Model = model;
            Color = color;
        }

        // Triển khai phương thức Start kiểu string, trả về chuỗi "Engine start"
        public virtual string Start()
        {
            return "Engine start";
        }

        // Triển khai phương thức Stop kiểu string, trả về chuỗi "Breaaak!"
        public string Stop()
        {
            return "Breaaak!";
        }

        // Triển khai phương thức ToString kiểu string
        public override string ToString()
        {
            return $"{Color} {GetType().Name} {Model}";
        }
    }

    // Khai báo lớp Seat kế thừa từ lớp ElectricCar
    public class Seat : ElectricCar
    {
        // Khai báo và triển khai thuộc tính Seats kiểu int
        public int Seats { get; set; }

        // Khởi tạo lớp Seat với ba tham số model, color, và seats, gọi đến hàm khởi tạo của lớp cha ElectricCar
        public Seat(string model, string color, int seats) : base(model, color)
        {
            Seats = seats;
        }

        // Ghi đè phương thức ToString kiểu string
        public override string ToString()
        {
            return $"{Color} Seat {Model} with {Seats} Seats";
        }
    }

    // Khai báo lớp Tesla kế thừa từ lớp ElectricCar
    public class Tesla : ElectricCar
    {
        // Khai báo và triển khai thuộc tính Batteries kiểu int
        public int Batteries { get; set; }

        // Khởi tạo lớp Tesla với ba tham số model, color, và batteries, gọi đến hàm khởi tạo của lớp cha ElectricCar
        public Tesla(string model, string color, int batteries) : base(model, color)
        {
            Batteries = batteries;
        }

        // Ghi đè phương thức ToString kiểu string
        public override string ToString()
        {
            return $"{Color} Tesla {Model} with {Batteries} Batteries";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ICar seat = new Seat("Leon", "Grey", 5);
            ICar tesla = new Tesla("Model 3", "Red", 2);

            Console.WriteLine(seat.ToString());
            Console.WriteLine(seat.Start());
            Console.WriteLine(seat.Stop());

            Console.WriteLine(tesla.ToString());
            Console.WriteLine(tesla.Start());
            Console.WriteLine(tesla.Stop());
        }
    }
}
