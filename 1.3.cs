using System;
class Program
{
    delegate bool Operation(int x);
    static void Main(string[] args)
    {
        int m, n;

        Console.WriteLine("Введите натуральное m ");
        m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите натуральное n ");
        n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n + 1];
        int y = m;
        int k = 1;
        array[m] = y;
        for (int i = m + 1; i < n + 1; i++)
        {
            array[i] = y + 1;
            y = array[i];
            k++;
        }
        int result = Sum(array, x => x > m - 1) / k;
        Console.WriteLine(result);
        Console.ReadLine();

    }
    private static int Sum(int[] numbers, Operation func)
    {
        int result = 0;
        foreach (int i in numbers)
        {
            if (func(i))
                result += i;
        }
        return result;
    }
}
