internal partial class Program_4
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine()!);
        Console.Write(number + " -> ");

        for (int i = 2; i <= number; i = i + 2) Console.Write(i + " ");

        Console.WriteLine();
    }
}