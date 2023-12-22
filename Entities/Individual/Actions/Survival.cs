namespace GeneticAlgorithm;

public class Survival : IAction
{
    public void Act(Individual ind)
    {
        ind.OnSurvive();
    }
}
