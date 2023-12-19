namespace GeneticAlgorithm;

public class DualCrossover : Recombination
{
    public DualCrossover(Algorithm algorithm) : base(algorithm)
    {

    }
    public override Pair Cross(Pair pair)
    {
        var rand = Algorithm.Random;
        int firstGap = rand.Next(0, Population.GenesCount / 2 + 1);
        int secondGap = rand.Next(firstGap + 1, Population.GenesCount);
        return GetGap(pair, firstGap, secondGap);
    }
    public override string ToString()
    {
        return "Двухточечный кроссовер";
    }
}
