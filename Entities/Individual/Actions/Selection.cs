namespace GeneticAlgorithm;

public class Selection : IAction
{
    public void Act(Individual ind)
    {
        ind.CalculateFitness();
    }
}
