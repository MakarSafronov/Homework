using System;
public class EquationSolver
{
    public static void SolveEquation(double a,double b, double c)
    {
        if (a==0)
        {
            if (b == 0)
            {
                if (c==0)
                {
                    Console.WriteLine("уравнение имеет бесконечно много решений");
                }
                else
                {
                    Console.WriteLine("уравнение не имеет решений");
                }
            }
            else
            {
                double x = -c/b;
                Console.WriteLine($"перед нами линейное уравнение и его решение: x={x}");
            }
        }
        else
        {
            double D = b*b-4*a*c;
            if (D>0)
            {
                double x1 = (-b+Math.Sqrt(D))/(2*a);
                double x2 = (-b-Math.Sqrt(D))/(2*a);
                Console.WriteLine($"уравнение имеет два решения: x1={x1}, x2={x2}");
            }
            else if (D==0)
            {
                double x = (-b)/(2*a);
                Console.WriteLine($"уравнение имеет одно решение: x={x}");
            }
            else
            {
                Console.WriteLine($"уравнение не имеет действительных решений");
            }
        }

    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("введите коэффициенты уравнения (a,b,c): ");
        Console.Write("a=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c=");
        double c = double.Parse(Console.ReadLine());
        EquationSolver.SolveEquation(a, b, c);
    }
}