internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine()!);
        Console.Write(number + " -> ");

        if (number % 2 == 0) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}