namespace GeneticAlgorithm;
using static Math;

internal class Rastrigin : IFunction
{
    public class Pair
    {
        internal double Value { get; set; } = double.MaxValue;
        internal Argument? Argument;
    }
    private readonly int A;
    public int N { get; set; }
    public Pair Best { get; } = new();

    public Rastrigin(int A, int n)
    {
        this.A = A;
        N = n;
    }
    public double GetValue(Argument arg)
    {
        var n = arg.N;
        var sum = 0d;
        foreach (var x in arg)
        {
            sum += x * x - A * Cos(2 * PI * x);
        }
        var result = A * n + sum;
        if (result < Best.Value)
        {
            Best.Value = result;
            Best.Argument = arg;
        }
        return result;
    }
}
