namespace GeneticAlgorithm;

public class Dying : IAction
{
    public void Act(Individual ind)
    {
        ind.Suicide();
    }
}
