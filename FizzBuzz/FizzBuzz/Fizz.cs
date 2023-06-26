namespace FizzBuzz;

public class Fizz : IDivisible
{
    public bool IsDivisible(int number)
    {
        return number % 3 == 0;
    }
}