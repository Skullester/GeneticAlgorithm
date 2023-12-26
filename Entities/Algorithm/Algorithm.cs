namespace GeneticAlgorithm;
public class Algorithm
{
    public const double MUTATION_PROBABILITY = 0.2;
    public const int START_SPEED = 40;
    public int Multiplier { get; set; }
    private readonly MainForm mainForm;
    public int Generation { get; private set; }
    private readonly IFunction function;
    public Random Random { get; } = new();
    public ParentChoosing? ParentChoosable { get; set; }
    public Recombination? Recombination { get; set; }
    public Population? Population { get; set; }
    public Thread Process { get; }
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
    public Algorithm(MainForm mainForm, IFunction function)
    {
        Process = new(Start);
        this.mainForm = mainForm;
        this.function = function;
    }
    public void SetSpeed()
    {
        Speed = START_SPEED / Multiplier;
    }

    public void Start()
    {
        Fitness.SetFunction(function);
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
    }
}
