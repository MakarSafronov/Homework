using System;
public class PrimeNumbers
{
    public static void print_primes(int n)
    {
        if (n<2)
        {
            Console.WriteLine("простых чисел нет");
            return;
        }
        bool[] isPrime = new bool[n+1];
        for (int i = 2; i<=n; i++)
        {
            isPrime[i] = true;
        }
        for (int i = 2; i*i<=n; i++)
        {
            if (isPrime[i])
            {
                for(int j = i*i; j<=n; j+=i)
                { 
                    isPrime[j] = false; 
                } 
            }
        }
        Console.WriteLine($"простые числа,не превосходяшие {n}:");
        for (int i = 2; i<=n; i++)
        {
            if (isPrime[i])
            {
                Console.Write(i+" ");
            }
        }
        Console.WriteLine();
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("введите число: ");
        int n=int.Parse(Console.ReadLine());
        PrimeNumbers.print_primes(n);
    }
}