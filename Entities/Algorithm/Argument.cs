using System.Collections;

namespace GeneticAlgorithm;

public class Argument(int n) : IEnumerable<double>
{
    private readonly double[] arguments = new double[n];
    public int N => arguments.Length;
    public double this[int index]
    {
        get => arguments[index];
        set => arguments[index] = value;
    }

    public IEnumerator<double> GetEnumerator()
    {
        return ((IEnumerable<double>)arguments).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
