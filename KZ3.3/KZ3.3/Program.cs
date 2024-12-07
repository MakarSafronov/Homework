using System;
using System.ComponentModel;
using System.Reflection;
public class ComplNumb
{
    public double Real { get; set; }
    public double Imag { get; set; }
    public ComplNumb(double real,double imag)
    {
        Real = real;
        Imag = imag;
    }
    public double Module()
    {
        return Math.Sqrt(Real * Real + Imag * Imag);
    }
    public double Arg()
    {
        return Math.Atan2(Imag, Real);
    }
    public static ComplNumb operator +(ComplNumb a, ComplNumb b)
    {
        return new ComplNumb(a.Real+b.Real,a.Imag+b.Imag);
    }
    public static ComplNumb operator -(ComplNumb a, ComplNumb b)
    {
        return new ComplNumb(a.Real-b.Real, a.Imag-b.Imag);
    }
    public static ComplNumb operator *(ComplNumb a, ComplNumb b)
    {
        double Realpart = a.Real*b.Real-a.Imag*b.Imag;
        double Imagpart = a.Real*b.Imag+a.Imag*b.Real;
        return new ComplNumb(Realpart,Imagpart);
    }
    public static ComplNumb operator /(ComplNumb a, ComplNumb b)
    {
        double denominator=b.Real*b.Real+b.Imag*b.Imag;
        if (denominator==0)
        {
            throw new DivideByZeroException("Попытка деления на 0");
        }
        double Realpart = (a.Real*b.Real+a.Imag*b.Imag)/denominator;
        double Imagpart = (a.Imag*b.Real-a.Real*b.Imag)/denominator;
        return new ComplNumb(Math.Round(Realpart,10), Math.Round(Imagpart,10));
    }
    public ComplNumb Power(int exponent)
    {
        double _Module = Module();
        double _Arg = Arg();
        double Resoltmodule=Math.Pow(_Module, exponent);
        double Resoltarg=_Arg*exponent;
        double Realpart=Resoltmodule*Math.Cos(Resoltarg);
        double Imagpart = Resoltmodule*Math.Sin(Resoltarg);
        return new ComplNumb(Realpart, Imagpart);
    }
    public ComplNumb[] Root(int degree)
    {
        if (degree <= 0)
        {
            throw new ArgumentException("Степень корня должна быть больше 0");
        }
        double _Module = Module();
        double _Arg = Arg();
        double resoltmoudle = Math.Pow(_Module, 1.0/degree);
        ComplNumb[] roots = new ComplNumb[degree];
        for (int k = 0; k < degree; k++)
        {
            double resoltarg = (_Arg+2*Math.PI*k)/degree;
            double realpart = resoltmoudle*Math.Cos(resoltarg);
            double imagpart = resoltmoudle*Math.Sin(resoltarg);
            roots[k]=new ComplNumb(realpart, imagpart);
        }
        return roots; 
    }
    public override bool Equals(object obj)
    {
        if (obj is ComplNumb other) {
            return Real==other.Real && Imag==other.Imag;
        } 
        return false;
    }
    public override string ToString()
    {
        if (Imag>=0)
        {
            return $"{Real} + {Imag}i";
        }
        else
        {
            return $"{Real} - {-Imag}i";
        }
    }
    public override int GetHashCode()
    {
        return Real.GetHashCode() ^ Imag.GetHashCode();
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        ComplNumb a = new ComplNumb(3, 4);
        ComplNumb b = new ComplNumb(1, 2);
        Console.WriteLine($"a={a}");
        Console.WriteLine($"b={b}");
        var summ = a+b; 
        Console.WriteLine($"a+b={summ}");
        var prod = a*b;
        Console.WriteLine($"a*b={prod}");
        var _div = a/b;
        Console.WriteLine($"a/b={_div}");
        var pow = a.Power(2);
        Console.WriteLine($"a^2={pow}");
        int degree = 2;
        var roots = a.Root(degree);
        Console.WriteLine($"{degree}-Й корень из а:");
        for(int i = 0; i < roots.Length; i++)
        {
            Console.WriteLine($"корень {i+1}: {roots[i]}");
        }
        var modul = a.Module();
        Console.WriteLine($"|a|={modul}");
        var angl = a.Arg();
        Console.WriteLine($"angel(a)={angl}");
    }
}