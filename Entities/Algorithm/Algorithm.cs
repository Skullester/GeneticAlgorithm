namespace GeneticAlgorithm;
public class Algorithm
{
    public const double MUTATION_PROBABILITY = 0.2;
    private const double alpha = 1E-4;
    public const int START_SPEED = 40;
    public int Multiplier { get; set; }
    private readonly MainForm mainForm;
    public int Generation { get; private set; }
    internal IFunction? Function { get; set; }
    public Random Random { get; } = new();
    public ParentChoosing? ParentChoosable { get; set; }
    public Recombination? Recombination { get; set; }
    public Population? Population { get; set; }
    // public Thread Process { get; }
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
        // Process = new(Start);
        this.mainForm = mainForm;
    }

    public void Start()
    {
        Generation = 0;
        while (Function!.Best.Value > alpha)
        {
            var parents = ParentChoosable!.FindPartners().ToList();
            //MessageBox.Show(parents.Average(x => x.First.Fitness).ToString());
            var sum = 0d;
            List<Individual> list = new();
            foreach (var parent in parents)
            {
                var pair = Recombination!.Cross(parent);
                foreach (var child in pair)
                {
                    list.Add(child);
                }
                //sum +=
                //Thread.Sleep(Speed);
                pair.Mutate();
                // Thread.Sleep(Speed);
                pair.Survive();
            }
            // Thread.Sleep(Speed);
            Generation++;
            mainForm.UpdateText(Function.Best.Value);
        }
        // Process.Interrupt();
        foreach (var x in Function.Best.Argument!)
        {
            mainForm.ListBoxArguments.Items.Add(x);
        }
    }
    public void SetSpeed()
    {
        Speed = START_SPEED / Multiplier;
    }

}
