using System.ComponentModel;

namespace GeneticAlgorithm;

public class SingleCrossover : Recombination
{
    public SingleCrossover(Algorithm algorithm) : base(algorithm)
    {

    }
    public override IEnumerable<(Individual, Individual)> Cross()
    {
        var random = new Random();
        var pop = Algorithm.Population;
        foreach (var ind in pop!)
        {
            yield return (new Individual(pop), new Individual(pop));
            //foreach (var partner in ind.Partners)
            //{
            //    var point = random.Next(0, pop!.GenesCount);
            //    var newGenes = partner.Genes[1..point];
            //    yield return (new Individual(pop), new Individual(pop));
            //}
        }
    }
    public override string ToString()
    {
        return "Одночечный кроссовер";
    }
}
