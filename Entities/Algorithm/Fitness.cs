namespace GeneticAlgorithm;

public static class Fitness
{
    public static double FitnessValue { get; private set; } = double.MaxValue;
    public const double Min = -5.12;
    public const double Max = 5.12;

    private static IFunction? function;
    public static double GetFitness(Individual individual)
    {
        if (function is null)
            throw new ArgumentException("Для начала определите функцию!");
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
