using System;
class Program
{
    delegate int Operation(int a, int b, int c);
    static void Main(string[] args)
    {
        int a, b, c;
        Console.WriteLine("Введите a ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите b ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите c ");
        c = Convert.ToInt32(Console.ReadLine());
        Operation Operation = (a, b, c) => { if (a > b && a > c) { return a; } else if (b > a && b > c) { return b; } else return c; };
        Console.WriteLine(Operation(a, b, c));
        Console.ReadLine();
    }
}
