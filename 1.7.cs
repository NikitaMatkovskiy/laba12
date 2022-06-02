using System;
class Program
{
    delegate double Operation(double x, double y);
    static void Main(string[] args)
    {
        int x, y;
        Console.WriteLine("Введите x ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите y ");
        y = Convert.ToInt32(Console.ReadLine());
        Operation Operation = (x, y) => Math.Sqrt(x * x + y * y);
        Console.WriteLine(Operation(x, y));
        Console.ReadLine();
    }
}
