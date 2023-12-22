using System.Diagnostics;

namespace GeneticAlgorithm;
public class Algorithm
{
    private readonly MainForm mainForm;
    public int Generation { get; private set; }
    public Random Random { get; } = new();
    public ParentChoosing? ParentChoosable { get; set; }
    public Recombination? Recombination { get; set; }
    public Population? Population { get; set; }
    public Thread Process { get; }
    public const int START_SPEED = 40;
    public int Speed { get; set; } = START_SPEED;

    // private readonly Fitness fitness;
    public Algorithm(MainForm mainForm)
    {
        //fitness = new(new Rastrigin(10));
        Process = new(Start);
        this.mainForm = mainForm;
    }
    public bool Fitness { get; set; }
    public void Start()
    {
        while (GeneticAlgorithm.Fitness.FitnessValue > 0.1)
        {
            var parents = ParentChoosable!.FindPartners().ToList();
            foreach (var parent in parents)
            {
                var pair = Recombination!.Cross(parent);
                //  Thread.Sleep(Speed);
                pair.Mutate();
                //  Thread.Sleep(Speed);
                pair.Survive();
                pair.Fitnes();
            }
            // Thread.Sleep(1000);
            foreach (var parent in parents)
            {
                parent.Reset();
            }
            Generation++;
            mainForm.UpdateText();
        }
        MessageBox.Show(GeneticAlgorithm.Fitness.FitnessValue.ToString());
        //var best = Population.Min(x => x.Fitness);
        //mainForm.UpdateText(best.ToString());
        //   mainForm.UpdateText(best.ToString());
    }
}
