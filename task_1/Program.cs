using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        int firstNamber = int.Parse(Console.ReadLine()!);
        Console.Write("Введите второе число: ");
        int secondNamber = int.Parse(Console.ReadLine()!);
        Console.Write("a = " + firstNamber + "; b = " + secondNamber + " -> max = ");
        if (firstNamber > secondNamber) Console.WriteLine(firstNamber);
        else Console.WriteLine(secondNamber);
    }
}