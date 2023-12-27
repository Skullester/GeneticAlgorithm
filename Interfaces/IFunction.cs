namespace GeneticAlgorithm;
public interface IFunction
{
    public int N { get; set; }
    Argument? Argument { get; set; }
    double GetValue();
}
