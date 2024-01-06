using System.Collections;

namespace GeneticAlgorithm;

public class Individual : IEnumerable<byte>
{
    public double Fitness { get; set; }
    public event Action<Color>? Handler;
    public Population Population { get; }
    internal byte[] Genes { get; set; }
    public Individual(Population pop) : this(pop, new byte[pop.GenesCount])
    {
    }

    public byte this[int index]
    {
        get => Genes[index];
        set => Genes[index] = value;
    }

    public double CalculateFitness()
    {
        Fitness = GeneticAlgorithm.Fitness.GetFitness(this);
        return Fitness;
    }

    public Individual(Population pop, params byte[] genes)
    {
        Population = pop;
        Genes = genes;
    }

    public void Suicide()
    {
        Handler?.Invoke(Color.Red);
    }

    public void Survive()
    {
        Handler?.Invoke(Color.ForestGreen);
    }

    public void Mutate()
    {
        Handler?.Invoke(Color.Yellow);
    }

    public void Reset()
    {
        Handler?.Invoke(Color.Black);
    }

    public override string ToString()
    {
        return string.Join("", Genes) + $" - {Fitness}";
    }

    public IEnumerator<byte> GetEnumerator()
    {
        return ((IEnumerable<byte>)Genes).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
