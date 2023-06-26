using FizzBuzz;
using Xunit;

namespace FizzBuzzTest;

public class BuzzTest
{
    [Theory]
    [InlineData(5, true)]
    [InlineData(7, false)]
    [InlineData(9, false)]
    [InlineData(10, true)]
    public void ShouldReturnTrueWhenDivisible(int inputNumber, bool expectedResult )
    {
        Buzz buzz = new();
        var result = buzz.IsDivisible(inputNumber);
        
        Assert.True(result == expectedResult);
    }
}