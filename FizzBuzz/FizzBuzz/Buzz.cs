namespace FizzBuzz;

public class Buzz : IDivisible
{
    public bool IsDivisible(int number)
    {
        return number % 5 == 0;
    }
}