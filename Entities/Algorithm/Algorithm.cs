namespace GeneticAlgorithm;
public class Algorithm
{
    public ParentChoosing? ParentChoosable { get; set; }
    public IRecombinationChoosable? RecombinationChoosable { get; set; }
    public Population? Population { get; set; }
    public bool Fitness { get; set; }

    public void Start()
    {
        ParentChoosable!.SetPartners();
    }
}
