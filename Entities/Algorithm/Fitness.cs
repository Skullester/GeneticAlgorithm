namespace GeneticAlgorithm;

public struct BestIndividual
{
    public double Fitness { get; private set; }
    public Individual individual { get; private set; }
}

public static class Fitness
{
    public const double MIN = -5.12;
    public const double MAX = 5.12;
    private static IFunction? function;
    public static BestIndividual BestIndividual { get; private set; }
    public static double FitnessValue { get; private set; } = double.MaxValue;
    public static double GetFitness(Individual individual)
    {
        var N = function!.N;
        Argument arg = BinaryDecoder.DecodeIndividual(individual, N);
        function!.Argument = arg;
        var fitness = function.GetValue();
        if (fitness < FitnessValue) // ищем минимум
            FitnessValue = fitness;
        return fitness;
    }
    public static void SetFunction(IFunction function)
    {
        Fitness.function = function;
    }
}
