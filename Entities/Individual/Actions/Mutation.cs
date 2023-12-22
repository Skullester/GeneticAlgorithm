using System;

namespace GeneticAlgorithm;

public class Mutation : IAction
{
    public void Act(Individual ind)
    {
        Random rand = new Random();
        if (rand.NextDouble() < 0.2)
        {
            ind[0] = ind[0] == 1 ? 0 : 1;
            ind.OnMutation();
        }
    }
}
