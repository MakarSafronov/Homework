using System;
public class Opera
{
    public static int OperaSteps(int n)
    {
        int steps = 0;
        while (n != 1)
        {
            if (n%2==0)
            {
                n/=2;
            }
            else
            {
                n=3*n+1;
            }
            steps++;
        }
        return steps;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введите число n: ");
        int n=int.Parse(Console.ReadLine());
        int steps=Opera.OperaSteps(n);
        Console.WriteLine($"Количество замен для числа {n}, приводящих к 1: {steps}");
    }
}