namespace GeneticAlgorithm;

public class Pair
{
    public Individual First { get; }
    public Individual Second { get; }
    public Pair((Individual, Individual) pairTuple)
    {
        First = pairTuple.Item1;
        Second = pairTuple.Item2;
    }

}
