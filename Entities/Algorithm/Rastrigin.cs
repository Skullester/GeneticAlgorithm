namespace GeneticAlgorithm;

public class Rastrigin : IFunction
{
    private readonly int A;
    public Rastrigin(int A)
    {
        this.A = A;
    }
    public double GetValue(double x, double y)
    {
        return A * 2 + Math.Pow(x, 2) - A * Math.Cos(2 * Math.PI * x) + Math.Pow(y, 2) - A * Math.Cos(2 * Math.PI * y);
    }
}
