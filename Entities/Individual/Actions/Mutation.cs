﻿using System;

namespace GeneticAlgorithm;

public class Mutation : IAction
{
    private const double probability = Algorithm.MUTATION_PROBABILITY;
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
            ind[index] = Convert.ToInt32(!isBitOne);
            var newFitness = ind.GetFitness();
            if (fitnessBefore < newFitness)
                ind[index] = Convert.ToInt32(isBitOne);
            else ind.OnMutation();
        }
    }
}
