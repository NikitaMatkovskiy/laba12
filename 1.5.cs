using System;
class Program
{
    delegate int Operation(int h, int m, int c);
    static void Main(string[] args)
    {
        int h, m, s;

        Console.WriteLine("Введите h ");
        h = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите m ");
        m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите s ");
        s = Convert.ToInt32(Console.ReadLine());
        Operation Operation = (h, m, s) => h * 60 * 60 + m * 60 + s;
        Console.WriteLine(Operation(h, m, s));

        Console.ReadLine();
    }
}
