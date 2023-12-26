using System.Collections;

namespace GeneticAlgorithm;

public class Argument : IEnumerable<double>
{
    private readonly double[] arguments;
    public int N => arguments.Length;
    public double this[int index]
    {
        get => arguments[index];
        set => arguments[index] = value;
    }
    public Argument(double[] args)
    {
        arguments = args;
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
