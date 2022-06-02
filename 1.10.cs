using System;
class Program
{
    delegate bool Operation(int x, int y);
    static void Main(string[] args)
    {
        int x, y;
        Console.WriteLine("Введите x ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите y ");
        y = Convert.ToInt32(Console.ReadLine());        
        Operation Operation = (x,y) => { if (x % y == 0) { return true; } else if (y % x == 0) { return true; } else return false; } ;
        Console.WriteLine(Operation(x, y)) ;
        Console.ReadLine();
    }
}