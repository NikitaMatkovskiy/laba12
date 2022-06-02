using System;
class Program
{
    delegate double Operation(double x, double y, double z);
    static void Main(string[] args)
    {
        int x, y, z;

        Console.WriteLine("Введите x ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите y ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите z ");
        z = Convert.ToInt32(Console.ReadLine());
        Operation Operation = (x, y, z) => { if (Math.Abs(x - y) > Math.Abs(y - z) && Math.Abs(x - y) > Math.Abs(z - x)) { return Math.Abs(x - y); } else if (Math.Abs(y - z) > Math.Abs(x - y) && Math.Abs(y - z) > Math.Abs(z - x)) { return Math.Abs(y - z); } else return Math.Abs(z - x); };
        Console.WriteLine(Operation(x, y, z));
        Console.ReadLine();
    }
}
