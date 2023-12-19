using System.Diagnostics;

namespace GeneticAlgorithm;
public class Algorithm
{
    public Random Random { get; } = new();
    public ParentChoosing? ParentChoosable { get; set; }
    public Recombination? Recombination { get; set; }
    public Population? Population { get; set; }
    public Thread Process { get; }
    public Algorithm()
    {
        Process = new(Start);
    }
    public bool Fitness { get; set; }
    public void Start()
    {
        //while (true)
        //{
        var parents = ParentChoosable!.FindPartners().ToList();
        foreach (var parent in parents)
        {
            var pair = Recombination!.Cross(parent);
            Thread.Sleep(500);
            pair.Mutate();
            Thread.Sleep(500);
            pair.Survive();
        }


        //}
    }
}
