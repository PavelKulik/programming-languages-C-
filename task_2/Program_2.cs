internal partial class Program_2
{
    private static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        int firstNumber = int.Parse(Console.ReadLine()!);
        Console.Write("Введите второе число: ");
        int secondNumber = int.Parse(Console.ReadLine()!);
        Console.Write("Введите третье число: ");
        int thirdNumber = int.Parse(Console.ReadLine()!);
        
        Console.Write(firstNumber + ", " + secondNumber + ", " + thirdNumber + " -> ");
        
        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine(firstNumber);
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            Console.WriteLine(secondNumber);
        }
        else Console.WriteLine(thirdNumber);
    }
}