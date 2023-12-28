namespace GeneticAlgorithm;
public class Algorithm
{
    public const double MUTATION_PROBABILITY = 0.2;
    private const double alpha = 1E-5;
    public const int START_SPEED = 40;
    public int Multiplier { get; set; }
    private readonly MainForm mainForm;
    public int Generation { get; private set; }
    internal IFunction? Function { get; set; }
    public Random Random { get; } = new();
    public ParentChoosing? ParentChoosable { get; set; }
    public Recombination? Recombination { get; set; }
    public Population? Population { get; set; }
    private Chart chart;
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
        chart = new(mainForm.Chart1);
        Generation = 0;
        var arg = 0;
        var tmp = 0d;
        while (Function!.Best.Value > alpha)
        {
            var parents = ParentChoosable!.FindPartners().ToList();
            List<Individual> list = new();
            foreach (var parent in parents)
            {
                var pair = Recombination!.Cross(parent);
                foreach (var child in pair)
                {
                    list.Add(child);
                }
                //Thread.Sleep(Speed);
                pair.Mutate();
                // Thread.Sleep(Speed);
                pair.Survive();
            }
            var min = list.Min(x => x.Fitness);
            var y = min;
            if (Generation > 0)
            {
                y = min - tmp;
                //var y = list.Min(x => x.Fitness);

            }
            chart.Draw(arg++, y);
            tmp = min;
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
