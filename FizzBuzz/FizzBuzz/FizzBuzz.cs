namespace FizzBuzz;

public class FizzBuzz
{
    private readonly List<IDivisible> _divisions = new List<IDivisible>();
    public IEnumerable<string> GenerateRange(int n)
    {
        foreach (int number in Enumerable.Range(1,n))
        {
            var divisionMatch = _divisions.Where(d=> d.IsDivisible(number)).ToList();
            yield return divisionMatch.Any() ? string.Join("", divisionMatch.Select(d => d.GetType().Name)) : number.ToString();
        }
    }

    public void AddDivision<T>(T division) where T : IDivisible
    {
         _divisions.Add(division);
    }
}