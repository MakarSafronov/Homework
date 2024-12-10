using System;
public class NumberValidator
{
    public const int Min = -2147483648;
    public const int Max = 2147483647;
    public static int ValidateInput(string input)
    {
        if (!int.TryParse(input, out int result))
        {
            throw new FormatException("Введено не число");
        }
        if (result < Min)
        {
            throw new ArgumentOutOfRangeException(nameof(input), "Введено слишком маленькое число");
        }
        if (result > Max)
        {
            throw new ArgumentOutOfRangeException(nameof(input), "Введено слишком большое число");
        }
        return result;
    }
}
