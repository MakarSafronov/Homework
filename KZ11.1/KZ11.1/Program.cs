using System;
using System.IO;
using System.Globalization;
class Program
{
    static void Main()
    {
        using (StreamWriter writer = new StreamWriter("f.txt"))
        {
            writer.WriteLine("x  sin(x)");
            for (double x = 0; x<=1; x+=0.1)
            {
                double sinX = Math.Sin(x);
                writer.WriteLine($"{x.ToString("0.0", CultureInfo.InvariantCulture)} {sinX.ToString("0.0000000", CultureInfo.InvariantCulture)}");
            }
        }
        Console.WriteLine("Таблица успешно записана в файл f.txt");
    }
}