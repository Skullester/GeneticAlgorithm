using System.ComponentModel;

namespace GeneticAlgorithm;

public class SingleCrossover : Recombination
{
    public SingleCrossover(Algorithm algorithm) : base(algorithm)
    {

    }
    public override IEnumerable<Pair> Cross(Pair pair)
    {
        const int pairCount = 2;
        var pop = Algorithm.Population!;
        var rand = new Random();
        var gapIndex = rand.Next(0, pop.GenesCount - 1);
        List<int[]> tails = new();
        List<Individual> newPair = new();
        for (int i = pairCount - 1; i > -1; i--)
        {
            var tail = pair[i].Genes[(gapIndex + 1)..pop.GenesCount];
            tails.Add(tail);
        }
        for (int i = 0; i < pairCount; i++)
        {
            var head = pair[i].Genes[0..(gapIndex + 1)];
            var tail = tails[i];
            var newArr = head.Concat(tail).ToArray();
            newPair.Add(new Individual(pop, newArr));
        }
        yield return new Pair(newPair);
    }
    public override string ToString()
    {
        return "Одноточечный кроссовер";
    }
}
