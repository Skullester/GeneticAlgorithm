namespace GeneticAlgorithm;

public class Individual
{
    public int Value { get; set; } //заглушка
    public event Action<Color>? Handler;
    public Individual? Partner { get; set; }
    public Population Population { get; }
    public int[] Genes { get; }
    public Individual(Population pop)
    {
        Population = pop;
        Genes = new int[pop.GenesCount];
    }
    public override string ToString()
    {
        return string.Join("", Genes);
    }
    public static (Individual, Individual) operator +(Individual parent1, Individual parent2)
    {
        return (new Individual(new Population(1)), new Individual(new Population(1)));//temp
    }
    public static (Individual, Individual) GetNewIndividuals(Individual parent1, Individual parent2) => parent1 + parent2;
    public void OnDying()
    {
        Handler?.Invoke(Color.Red);
    }
    public void OnSurvive()
    {
        Handler?.Invoke(Color.Green);
    }
}
