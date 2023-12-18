using System.ComponentModel;

namespace GeneticAlgorithm;

public class DualCrossover : Recombination
{
    public DualCrossover(Algorithm algorithm) : base(algorithm)
    {

    }
    public override IEnumerable<Pair> Cross(Pair pair)
    {
        var random = new Random();
        var pop = Algorithm.Population;
        foreach (var ind in pop!)
        {
            yield return new Pair((new Individual(pop), new Individual(pop)));
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
        return "Двухточечный кроссовер";
    }
}
