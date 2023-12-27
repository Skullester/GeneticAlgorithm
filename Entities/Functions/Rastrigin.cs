namespace GeneticAlgorithm;
using static Math;
public class Rastrigin : IFunction
{
    private readonly int A;
    public Argument? Argument { get; set; }
    public int N { get; set; }
    public Rastrigin(int A, int n)
    {
        this.A = A;
        N = n;
    }
    public double GetValue()
    {
        var n = Argument.N;
        var sum = 0d;
        foreach (var x in Argument)
        {
            sum += Round(x * x - A * Cos(2 * PI * x));
        }
        var result = A * n + sum;
        return result;
    }
}
