namespace GeneticAlgorithm;
public class Algorithm
{
    public ParentChoosing? ParentChoosable { get; set; }
    public Recombination? Recombination { get; set; }
    public Population? Population { get; set; }
    public bool Fitness { get; set; }
    public void Start()
    {
        while (true)
        {
            var parents = ParentChoosable!.FindPartners();
            foreach (var item in parents)
            {
                Recombination!.Cross(item);
            }


        }
    }
}
