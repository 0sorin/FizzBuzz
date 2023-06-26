using Xunit;

namespace TestProject1;

public class FizzBuzzTest
{
    [Fact]
    public void Test()
    {
        int input = 100;
        int expectedOutputLength = 100;

        FizzBuzz.FizzBuzz fizzBuzz = new();
        var result = fizzBuzz.GenerateRange(input);
        
        Assert.True(result.Length == expectedOutputLength);
    }
}