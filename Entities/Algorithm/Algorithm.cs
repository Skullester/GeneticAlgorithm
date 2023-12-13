namespace GeneticAlgorithm;
public class Algorithm
{
    public ParentChoosing? ParentChoosable { get; set; }
    public Recombination? Recombination { get; set; }
    public Population? Population { get; set; }
    public bool Fitness { get; set; }

    public void Start()
    {
        //while (true)
        ParentChoosable!.FindPartners();
        Recombination!.Cross();
    }
}
