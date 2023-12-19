using System.Collections;

namespace GeneticAlgorithm;

public class Population : IEnumerable<Individual>
{
    public int GenesCount { get; }
    private readonly List<Individual> individuals;
    public int Count => individuals.Count;
    public Population(int genesCount)
    {
        GenesCount = genesCount;
        individuals = new();
    }
    public Individual this[int index]
    {
        get => individuals[index];
    }
    public static Population GetRandomPopulation(int genesCount)
    {
        /* var individualsCount = Math.Pow(2, genesCount);*/
        var individualsCount = 900;
        Random rand = new();
        Population pop = new(genesCount);
        for (int i = 0; i < individualsCount; i++)
        {
            Individual individual = new(pop);
            for (int j = 0; j < genesCount; j++)
            {
                individual.Genes[j] = rand.Next(0, 1 + 1);
            }
            individual.Value = rand.Next(0, 128);
            pop.individuals.Add(individual);
        }
        return pop;
    }

    public IEnumerator<Individual> GetEnumerator()
    {
        return individuals.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
