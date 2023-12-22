namespace GeneticAlgorithm;
public class Reset : IAction
{
    public void Act(Individual ind)
    {
        ind.OnReset();
    }
}
