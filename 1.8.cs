using System;
class Program
{
    delegate int Operation(int n, int m);
    static void Main(string[] args)
    {
        int n, m;
        Console.WriteLine("Введите n ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите m ");
        m = Convert.ToInt32(Console.ReadLine());
        Operation Operation = (n, m) => (n / m + 1) * m;
        Console.WriteLine(Operation(n, m));
        Console.ReadLine();
    }
}
