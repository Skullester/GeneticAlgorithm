namespace GeneticAlgorithm;

public class Rastrigin : IFunction
{
    private const double MIN = -5.12;
    private const double MAX = 5.12;
    private readonly int A;
    public Rastrigin(int a)
    {
        this.A = a;
    }
    public double GetValue(double x, double y)
    {
        return A * 2 + Math.Pow(x, 2) - A * Math.Cos(2 * Math.PI * x) + Math.Pow(y, 2) - A * Math.Cos(2 * Math.PI * y);
    }
}
