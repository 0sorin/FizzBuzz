using System.Linq;
using FizzBuzz;
using Xunit;

namespace FizzBuzzTest;

public class FizzBuzzTest
{
    [Fact]
    public void TestLength()
    {
        int input = 100;
        int expectedOutputLength = 100;

        FizzBuzz.FizzBuzz fizzBuzz = new();
        var result = fizzBuzz.GenerateRange(input);
        
        Assert.True(result.Count() == expectedOutputLength);
    }
    
    [Fact]
    public void NoDivisions_ReturnsRange()
    {
        int input = 100;
        var expectedOutput = Enumerable.Range(1,input);

        FizzBuzz.FizzBuzz fizzBuzz = new();
        var result = fizzBuzz.GenerateRange(input);
        
        Assert.All(expectedOutput, number => Assert.Contains(number.ToString(), result));
    }
    
    [Fact]
    public void ReturnsFizz()
    {
        int input = 3;
        var expectedOutput = nameof(Fizz);

        FizzBuzz.FizzBuzz fizzBuzz = new();
        fizzBuzz.AddDivision(new Fizz());
        var result = fizzBuzz.GenerateRange(input);
        
        Assert.Equal(expectedOutput, result.Last());
    }
    
    [Fact]
    public void ReturnsBuzz()
    {
        int input = 5;
        var expectedOutput = nameof(Buzz);

        FizzBuzz.FizzBuzz fizzBuzz = new();
        fizzBuzz.AddDivision(new Buzz());
        var result = fizzBuzz.GenerateRange(input);
        
        Assert.Equal(expectedOutput, result.Last());
    }
    
    [Fact]
    public void ReturnsFizzBuzz()
    {
        int input = 15;
        var expectedOutput = nameof(Fizz) + nameof(Buzz);

        FizzBuzz.FizzBuzz fizzBuzz = new();
        fizzBuzz.AddDivision(new Fizz());
        fizzBuzz.AddDivision(new Buzz());
        var result = fizzBuzz.GenerateRange(input);
        
        Assert.Equal(expectedOutput, result.Last());
    }
    
    
    [Fact]
    public void ReturnsNumber()
    {
        int input = 22;
        var expectedOutput = input.ToString();

        FizzBuzz.FizzBuzz fizzBuzz = new();
        fizzBuzz.AddDivision(new Fizz());
        fizzBuzz.AddDivision(new Buzz());
        var result = fizzBuzz.GenerateRange(input);
        
        Assert.Equal(expectedOutput, result.Last());
    }
}