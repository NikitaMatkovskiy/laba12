using System;
class Program
{
    delegate bool Operation(double x, double y, double z);
    static void Main(string[] args)
    {
        double x, y, z;

        Console.WriteLine("Введите сторону x ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите сторону y ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите сторону z ");
        z = Convert.ToDouble(Console.ReadLine());

        Operation Operation = (x, y, z) => z < x + y;
        if (Operation(x, y, z) == true)
        {
            Console.WriteLine("true");
        }
        else Console.WriteLine("false");

        Console.ReadLine();

    }
}
