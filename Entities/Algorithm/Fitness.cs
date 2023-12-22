using System.Windows.Forms.DataVisualization.Charting;

namespace GeneticAlgorithm;

public static class Fitness
{
    private const double MIN = -5.12;
    private const double MAX = 5.12;
    private static readonly IFunction function;
    public static double FitnessValue { get; private set; } = double.MaxValue;
    //private Chart? visualizer;
    //public Fitness(IFunction function)
    //{
    //    this.function = function;
    //}
    static Fitness()
    {
        function = new Rastrigin(10);
    }
    public static double GetFitness(Individual individual)
    {
        var genes = individual.Genes;
        var str = string.Join("", genes);
        var length = str.Length / 2;
        string xBinary = str.Substring(0, length);
        string yBinary = str.Substring(length);
        var x = BinaryDecoder.Normalize(MAX, MIN, xBinary);
        var y = BinaryDecoder.Normalize(MAX, MIN, yBinary);

        var fitness = function.GetValue(x, y);
        if (fitness < FitnessValue) // ищем минимум
            FitnessValue = fitness;
        return fitness;
    }
    //private string CorrectFunction()
    //{
    //    var sb = new StringBuilder(startFunction);
    //    var index = startFunction.IndexOf('x', 0);
    //    while (index != -1)
    //    {
    //        sb.Insert(index, "*");
    //        index = startFunction.IndexOf('x', index + 1);

    //    }
    //    return sb.ToString();
    //}
    //private void DrawGraph(string fixedStr)
    //{
    //    var x = 0d;
    //    for (int i = 0; i < 10; i++)
    //    {
    //        var ch = (char)(x + '0');
    //        var str = fixedStr.Replace('x', ch);
    //        var y = Convert.ToDouble(new DataTable().Compute(str, ""));
    //        visualizer.Series[0].Points.AddXY(x, y);
    //        x += 1f;
    //    }
    //}


}
