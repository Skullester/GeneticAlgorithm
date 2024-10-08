﻿using System.Collections;

namespace GeneticAlgorithm;

public class Population : IEnumerable<Individual>
{
    public int GenesCount { get; }
    private readonly List<Individual> individuals;
    public int Count { get; }
    public Population(int genesCount, int indCount)
    {
        GenesCount = genesCount;
        Count = indCount;
        individuals = new();
    }
    public Individual this[int index]
    {
        get => individuals[index];
    }

    public static Population GetRandomPopulation(int genesCount, int indCount)
    {
        Random rand = new();
        Population pop = new(genesCount, indCount);
        for (int i = 0; i < pop.Count; i++)
        {
            Individual individual = new(pop);
            for (int j = 0; j < genesCount; j++)
            {
                individual[j] = (byte)rand.Next(0, 1 + 1);
            }
            individual.Fitness = Fitness.GetFitness(individual);
            pop.Add(individual);
        }
        return pop;
    }
    private void Add(Individual individual)
    {
        individuals.Add(individual);
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
