namespace GeneticAlgorithm;

public class Individual
{
    public int Value { get; set; } //заглушка
    public event Action<Color>? Handler;
    //public HashSet<Individual> Partners { get; set; } = new();
    public Population Population { get; }
    public int[] Genes { get; }
    public Individual(Population pop) : this(pop, new int[pop.GenesCount])
    {
    }
    public Individual(Population pop, params int[] genes)
    {
        Population = pop;
        Genes = genes;
    }
    //public static (Individual, Individual) operator +(Individual parent1, Individual parent2)
    //{
    //    return Population.RecombinationType.Cross();
    //    //     return (new Individual(new Population(1)), new Individual(new Population(1)));//temp
    //}
    //public static (Individual, Individual) Cross(Individual parent1, Individual parent2) => parent1 + parent2;
    //public (Individual, Individual) CrossWith(Individual parent2) => this + parent2;
    public void OnDying()
    {
        Handler?.Invoke(Color.Red);
        Population.RemoveIndividual(this);
    }
    public void OnSurvive()
    {
        Handler?.Invoke(Color.Green);
    }
    public void OnCrossing()
    {
        Handler?.Invoke(Color.Yellow);
    }
    public override string ToString()
    {
        return string.Join("", Genes);
    }
}
