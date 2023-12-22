using System.Diagnostics;

namespace GeneticAlgorithm;
public class Algorithm
{
    public Random Random { get; } = new();
    public ParentChoosing? ParentChoosable { get; set; }
    public Recombination? Recombination { get; set; }
    public Population? Population { get; set; }
    public Thread Process { get; }
    public const int START_SPEED = 40;
    public int Speed { get; set; } = START_SPEED;
    private readonly Fitness fitness;
    public Algorithm()
    {
        fitness = new(new Rastrigin(10));
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
            Thread.Sleep(Speed);
            pair.Mutate();
            Thread.Sleep(Speed);
            pair.Survive();
        }


        //}
    }
}
