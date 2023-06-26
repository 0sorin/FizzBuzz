using FizzBuzz;
using Xunit;

namespace FizzBuzzTest;

public class FizzTest
{
    [Theory]
    [InlineData(3, true)]
    [InlineData(5, false)]
    [InlineData(6, true)]
    [InlineData(7, false)]
    public void ShouldReturnTrueWhenDivisible(int inputNumber, bool expectedResult )
    {
        Fizz fizz = new();
        var result = fizz.IsDivisible(inputNumber);
        
        Assert.True(result == expectedResult);
    }
}