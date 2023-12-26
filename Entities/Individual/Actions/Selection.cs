namespace GeneticAlgorithm;

public class Selection : IAction
{
    //  private Fitness fitness;
    public void Act(Individual ind)
    {
        ind.Fitness = Fitness.GetFitness(ind);
    }
}
