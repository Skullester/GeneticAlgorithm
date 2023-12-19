using System.ComponentModel;

namespace GeneticAlgorithm;

public class SingleCrossover : Recombination
{
    public SingleCrossover(Algorithm algorithm) : base(algorithm)
    {

    }
    public override Pair Cross(Pair pair)
    {
        var rand = Algorithm.Random;
        var gapIndex = rand.Next(0, Population.GenesCount - 1);
        return GetGap(pair, gapIndex, Population.GenesCount - 1);
    }
    public override string ToString()
    {
        return "Одноточечный кроссовер";
    }
}
