namespace GeneticAlgorithm;
using static Math;

internal class Rastrigin : IFunction
{
    internal class Pair
    {
        internal double value { get; set; } = double.MaxValue;
        internal Argument? argument;
        internal void Reset()
        {
            value = double.MaxValue;
            argument = default;
        }
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
        if (result < Best.value)
        {
            Best.value = result;
            Best.argument = arg;
        }
        return result;
    }
}
