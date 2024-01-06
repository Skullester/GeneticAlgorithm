using System;

namespace GeneticAlgorithm;

public class Mutation : IAction
{
    private readonly double probability = Algorithm.MutationProbability;
    private readonly Random random;
    public Mutation()
    {
        random = new Random();
    }
    public void Act(Individual ind)
    {
        if (random.NextDouble() < probability)
        {
            var fitnessBefore = ind.Fitness;
            var index = random.Next(0, ind.Population.GenesCount);
            var isBitOne = ind[index] == 1;
            ind[index] = Convert.ToByte(!isBitOne);
            var newFitness = ind.CalculateFitness();
            if (fitnessBefore < newFitness)
                ind[index] = Convert.ToByte(isBitOne);
            else ind.Mutate();
        }
    }
}
