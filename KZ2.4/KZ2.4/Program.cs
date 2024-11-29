using System;
public class BSort
{
    public static void Sort(int[] aray)
    {
        int n = aray.Length;
        for (int i = 0; i<n; i++)
        {
            bool swaped = false;
            for (int j = 0; j<n-1-i; j++)
            {
                if (aray[j]>aray[j+1])
                {
                    int temp = aray[j];
                    aray[j]=aray[j+1];
                    aray[j+1]=temp;
                    swaped=true;
                }
            }
            if (!swaped)
            {
                break;
            }
        }
    }
    public static void PrintAray(int[] aray)
    {
        foreach (int i in aray)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        int[] aray = { 16, 31, 94, 34, 21, 51, 43, 78, 81, 4 };
        Console.WriteLine("Исходный массив: ");
        BSort.PrintAray(aray);
        BSort.Sort(aray);
        Console.WriteLine("Отсортированный массив: ");
        BSort.PrintAray(aray);
    }
}
