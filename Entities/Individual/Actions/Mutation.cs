using System;

namespace GeneticAlgorithm;

public class Mutation : IAction
{
    private const double probability = Algorithm.MutationProbability;
    private readonly Random random;
    public Mutation()
    {
        random = new Random();
    }
    public void Act(Individual ind)
    {
        if (random.NextDouble() < probability)
        {
            var index = random.Next(0, ind.Population.GenesCount);
            ind[index] = ind[index] == 1 ? 0 : 1;
            ind.OnMutation();
        }
    }
}
