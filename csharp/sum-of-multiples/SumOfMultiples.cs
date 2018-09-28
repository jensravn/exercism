using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max) =>
        Enumerable
            .Range(0, max)
            .Select(i => multiples.Any(m => i % m == 0) ? i : 0)
            .Sum();
}