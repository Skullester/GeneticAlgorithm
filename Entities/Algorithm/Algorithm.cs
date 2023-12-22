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
    private int speed = START_SPEED;
    private bool IsAccelerated => mainForm.checkBoxAccelerated.Checked;
    public int Speed { get => speed; set { if (IsAccelerated) speed = 0; else speed = value; } }

    // private readonly Fitness fitness;
    public Algorithm(MainForm mainForm)
    {
        Process = new(Start);
        this.mainForm = mainForm;
    }
    public bool Fitness { get; set; }
    public void Start()
    {
        while (GeneticAlgorithm.Fitness.FitnessValue > 0.01)
        {
            var parents = ParentChoosable!.FindPartners().ToList();
            foreach (var parent in parents)
            {
                var pair = Recombination!.Cross(parent);
                Thread.Sleep(Speed);
                pair.Mutate();
                Thread.Sleep(Speed);
                pair.Survive();
                pair.Fitnes();
            }
            foreach (var parent in parents)
            {
                parent.Reset();
            }
            Thread.Sleep(Speed);
            Generation++;
            mainForm.UpdateText();
        }
        // MessageBox.Show(GeneticAlgorithm.Fitness.FitnessValue.ToString());
        //var best = Population.Min(x => x.Fitness);
        //mainForm.UpdateText(best.ToString());
        //   mainForm.UpdateText(best.ToString());
    }
}
