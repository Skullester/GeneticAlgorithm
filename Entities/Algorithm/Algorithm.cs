namespace GeneticAlgorithm;
public class Algorithm
{
    public Random Random { get; } = new();
    public ParentChoosing? ParentChoosable { get; set; }
    public Recombination? Recombination { get; set; }
    public Population? Population { get; set; }
    public bool Fitness { get; set; }
    public void Start()
    {
        //while (true)
        //{
        var parents = ParentChoosable!.FindPartners().ToList();
        foreach (var parent in parents)
        {
            Recombination!.Cross(parent).Mutate();
        }


        //}
    }
}
