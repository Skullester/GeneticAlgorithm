namespace GeneticAlgorithm;
internal interface IFunction
{
    public int N { get; set; }
    double GetValue(Argument arg);
    Rastrigin.Pair Best { get; }
}
