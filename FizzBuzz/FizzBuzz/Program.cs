using FizzBuzz;

FizzBuzz.FizzBuzz fizzBuzz = new ();
fizzBuzz.AddDivision(new Fizz());
fizzBuzz.AddDivision(new Buzz());

Console.Write(string.Join(", ", fizzBuzz.GenerateRange(100)));