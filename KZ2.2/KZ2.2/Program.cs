using System;
public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = new int[10];
        Console.WriteLine("Введите десять различных чисел: ");
        for (int i = 0; i < 10; i++)
        { 
            Console.Write($"число {i+1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int max = numbers[0];
        int secondmax = int.MinValue;
        for (int i = 0; i < 10; i++)
        {
            if (numbers[i] > max)
            {
                secondmax = max;
                max = numbers[i];
            }
            else if (numbers[i] > secondmax)
            {
                secondmax= numbers[i];
            }
        }
        Console.WriteLine($"Наибольшее число: {max}");
        Console.WriteLine($"Следующее по величине число: {secondmax}");
    }
}