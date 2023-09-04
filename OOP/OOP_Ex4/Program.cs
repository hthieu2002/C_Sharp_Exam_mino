using OOP_Ex4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first fraction (numerator denominator):");
        string[] fraction1Input = Console.ReadLine().Split();
        int numerator1 = int.Parse(fraction1Input[0]);
        int denominator1 = int.Parse(fraction1Input[1]);
        Fraction fraction1 = new Fraction(numerator1, denominator1);

        Console.WriteLine("Enter the second fraction (numerator denominator):");
        string[] fraction2Input = Console.ReadLine().Split();
        int numerator2 = int.Parse(fraction2Input[0]);
        int denominator2 = int.Parse(fraction2Input[1]);
        Fraction fraction2 = new Fraction(numerator2, denominator2);

        Fraction resultAdd = fraction1.Add(fraction2);
        Fraction resultSubtract = fraction1.Subtract(fraction2);
        Fraction resultMultiply = fraction1.Multiply(fraction2);
        Fraction resultDivide = fraction1.Divide(fraction2);

        Console.WriteLine("Result of Addition:");
        resultAdd.Display();
        resultAdd.DisplayDecimal();

        Console.WriteLine("Result of Subtraction:");
        resultSubtract.Display();
        resultSubtract.DisplayDecimal();

        Console.WriteLine("Result of Multiplication:");
        resultMultiply.Display();
        resultMultiply.DisplayDecimal();

        Console.WriteLine("Result of Division:");
        resultDivide.Display();
        resultDivide.DisplayDecimal();
    }
}