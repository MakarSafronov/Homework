using System;
using Xunit;
public class NumberValidatorTests
{
    [Theory]
    [InlineData("123", 123)]
    [InlineData("-2147483648", -2147483648)]
    [InlineData("2147483647", 2147483647)]
    public void ValidateInput_ValidInput_ReturnsParsedNumber(string input, int expected)
    {
        var result = NumberValidator.ValidateInput(input);
        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData("not_a_number")]
    [InlineData("123.45")]
    [InlineData("abc")]
    public void ValidateInput_NonNumeric_ThrowsFormatException(string input)
    {
        var exception = Assert.Throws<FormatException>(() => NumberValidator.ValidateInput(input));
        Assert.Equal("¬ведено не число", exception.Message);
    }
    [Theory]
    [InlineData("-2147483649")]
    [InlineData("-1000000000000")]
    public void ValidateInput_InputTooSmall_ThrowsArgumentOutOfRangeException(string input)
    {
        var exception = Assert.Throws<ArgumentOutOfRangeException>(() => NumberValidator.ValidateInput(input));
        Assert.Equal("¬ведено слишком маленькое число", exception.Message);
    }
    [Theory]
    [InlineData("2147483648")]
    [InlineData("1000000000000")]
    public void ValidateInput_InputTooLarge_ThrowsArgumentOutOfRangeException(string input)
    {
        var exception = Assert.Throws<ArgumentOutOfRangeException>(() => NumberValidator.ValidateInput(input));
        Assert.Equal("¬ведено слишком большое число", exception.Message);
    }
}