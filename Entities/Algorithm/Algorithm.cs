namespace GeneticAlgorithm;
public class Algorithm
{
    public int Multiplier { get; set; }
    private readonly MainForm mainForm;
    public int Generation { get; private set; }
    public Random Random { get; } = new();
    public ParentChoosing? ParentChoosable { get; set; }
    public Recombination? Recombination { get; set; }
    public Population? Population { get; set; }
    public const double MutationProbability = 0.2;
    public Thread Process { get; }
    public const int START_SPEED = 40;
    private int speed = START_SPEED;
    private bool IsAccelerated => mainForm.checkBoxAccelerated.Checked;
    public int Speed
    {
        get => speed;
        set
        {
            if (IsAccelerated)
                speed = 0;
            else
                speed = value;
        }
    }
    public Algorithm(MainForm mainForm)
    {
        Process = new(Start);
        this.mainForm = mainForm;
    }
    public void SetSpeed()
    {
        Speed = START_SPEED / Multiplier;
    }

    public void Start()
    {
        while (Fitness.FitnessValue > 0.01)
        {
            var parents = ParentChoosable!.FindPartners().ToList();
            foreach (var parent in parents)
            {
                var pair = Recombination!.Cross(parent);
                Thread.Sleep(Speed);
                pair.Mutate();
                Thread.Sleep(Speed);
                pair.Survive();
                pair.Select();
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
