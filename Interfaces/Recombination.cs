namespace GeneticAlgorithm;

public abstract class Recombination
{
    protected Algorithm Algorithm { get; }
    public abstract IEnumerable<Pair> Cross(Pair pair);
    public Recombination(Algorithm algorithm)
    {
        Algorithm = algorithm;
    }
}
