using System.Diagnostics;

namespace GeneticAlgorithm;
public class Algorithm
{
    public static double MUTATION_PROBABILITY = 0.2;
    public int MaxGenerations { get; set; }
    private const double alpha = 1E-5;//-3
    public const int START_SPEED = 40;
    public int Multiplier { get; set; }
    private readonly MainForm mainForm;
    public int Generation { get; private set; }
    internal IFunction? Function { get; set; }
    public Random Random { get; } = new();
    public ParentChoosing? ParentChoosable { get; set; }
    public Recombination? Recombination { get; set; }
    public Population? Population { get; set; }
    public Chart? chart { get; private set; }
    // public Thread Process { get; }
    private int speed = START_SPEED;
    private bool IsAccelerated => mainForm.checkBoxAccelerated.Checked;
    public bool IsSucceed { get; private set; }
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

    private void Reset()
    {
        Function!.Best.Reset();
        Generation = 0;
        mainForm.UpdateText(string.Empty, 0);
        chart.Reset();
    }
    public void Start()
    {
        chart = new(mainForm.Chart1); Reset();
        var arg = 0;
        //var tmp = 0d;
        Stopwatch sw = Stopwatch.StartNew();
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
            var y = list.Min(x => x.Fitness);
            //var y = min;
            //if (Generation > 0)
            //{
            //    y = min - tmp;
            //    //var y = list.Min(x => x.Fitness);

            //}
            chart.Draw(arg++, y);
            //tmp = min;
            // Thread.Sleep(Speed);
            Generation++;
            if (Generation == MaxGenerations)
            {
                var gen = Generation;
                var value = Function!.Best.Value;
                MessageBox.Show($"Решение не найдено! \nGen: {gen} \nFitness: {value}\nИзмените настройки алгоритма!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
                return;
            }
        }
        sw.Stop();
        var milliseconds = sw.ElapsedMilliseconds;
        mainForm.UpdateText(Function.Best.Value, milliseconds);
        // Process.Interrupt();
        foreach (var x in Function.Best.Argument!)
        {
            mainForm.ListBoxArguments.Items.Add(x);
        }
        IsSucceed = true;
    }
    public void SetSpeed()
    {
        Speed = START_SPEED / Multiplier;
    }

}
