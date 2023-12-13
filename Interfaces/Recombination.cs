namespace GeneticAlgorithm;

public abstract class Recombination
{
    protected Algorithm Algorithm { get; }
    public abstract IEnumerable<(Individual, Individual)> Cross();
    public Recombination(Algorithm algorithm)
    {
        Algorithm = algorithm;
    }
}
