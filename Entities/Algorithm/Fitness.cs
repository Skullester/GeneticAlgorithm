namespace GeneticAlgorithm;

public static class Fitness
{
    public const double MIN = -5.12;
    public const double MAX = 5.12;
    private static IFunction? function;
    public static double FitnessValue { get; private set; } = double.MaxValue;
    public static double GetFitness(Individual individual)
    {
        var N = function!.N;
        Argument arg = BinaryDecoder.DecodeIndividual(individual, N);
        var fitness = function.GetValue(arg);
        return fitness;
    }
    internal static void SetFunction(IFunction function)
    {
        Fitness.function = function;
    }
}
