using System.Windows.Forms.DataVisualization.Charting;

namespace GeneticAlgorithm;

public static class Fitness
{
    private const double MIN = -5.12;
    private const double MAX = 5.12;
    private static IFunction? function;
    public static double FitnessValue { get; private set; } = double.MaxValue;
    public static double GetFitness(Individual individual)
    {
        var genes = individual.Genes;
        var str = string.Join("", genes);
        var length = str.Length / 2;
        string xBinary = str.Substring(0, length);
        string yBinary = str.Substring(length);
        var x = BinaryDecoder.Normalize(MAX, MIN, xBinary);
        var y = BinaryDecoder.Normalize(MAX, MIN, yBinary);
        return 0;
        // var fitness = function.GetValue(x, y);
        //if (fitness < FitnessValue) // ищем минимум
        //    FitnessValue = fitness;
        //return fitness;
    }
    public static void SetFunction(IFunction function)
    {
        Fitness.function = function;
    }
}
