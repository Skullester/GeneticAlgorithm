namespace GeneticAlgorithm;
using static Math;
public class Rastrigin : IFunction
{
    private readonly int A;
    private readonly Argument argument;
    public Rastrigin(int A, int N)
    {
        this.A = A;
        argument = new(N);
    }
    public double GetValue()
    {
        var n = argument.N;
        var sum = 0d;
        foreach (var x in argument)
        {
            sum += Round(x * x - A * Cos(2 * PI * x));
        }
        var result = A * n + sum;
        return result;
    }
}
