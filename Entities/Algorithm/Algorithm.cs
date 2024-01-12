using System.Diagnostics;

namespace GeneticAlgorithm;
public class Algorithm
{
    public static double MutationProbability { get; private set; } = 0.01;
    private const double delta = 1E-5;

    public Random Random { get; } = new();
    public ParentChoosing? ParentChoosable { get; set; }
    public Recombination? Recombination { get; set; }
    public Population? Population { get; set; }
    public int MaxGenerations { get; set; }
    public int Generation { get; private set; }

    private readonly MainForm mainForm;
    internal IFunction? Function { get; set; }
    private readonly Chart chart;
    public Algorithm(MainForm mainForm)
    {
        this.mainForm = mainForm;
        chart = new(mainForm.Chart1);
    }

    private void Reset()
    {
        Function!.Best.Reset();
        Generation = 0;
        chart!.Reset();
    }
    public static void SetMutation(double p) => MutationProbability = p;

    public void Start()
    {
        Reset();
        var arg = 0;
        Stopwatch sw = Stopwatch.StartNew();
        while (Function!.Best.value > delta)
        {
            var parents = ParentChoosable!.FindPartners().ToList();
            List<Individual> list = new();
            foreach (var parent in parents)
            {
                var pair = Recombination!.Cross(parent);
                foreach (var child in pair)
                    list.Add(child);
                pair.Mutate();
                pair.Survive();
            }
            var y = list.Min(x => x.Fitness);
            chart.Draw(arg++, y);
            Generation++;
            if (Generation == MaxGenerations)
            {
                var gen = Generation;
                var value = Function!.Best.value;
                MessageBox.Show($"Решение не найдено! \nGen: {gen} \nFitness: {value}\nИзмените настройки алгоритма!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            mainForm.LabelGeneration.Invoke(() => mainForm.LabelGeneration.Text = "Поколение: " + Generation + " Оптимум: " + Function.Best.value);
        }
        sw.Stop();
        var milliseconds = sw.ElapsedMilliseconds;
        mainForm.LabelAlgorithmTime.Invoke(() => mainForm.LabelAlgorithmTime.Text = "Потраченное время: " + milliseconds.ToString() + " мс");
        foreach (var x in Function.Best.argument!)
            mainForm.ListBoxArguments.Invoke(() => mainForm.ListBoxArguments.Items.Add(x));
        MessageBox.Show("Решение найдено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
