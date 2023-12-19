﻿namespace GeneticAlgorithm;

public class Individual
{
    public int Value { get; set; } //заглушка
    public event Action<Color>? Handler;
    public Population Population { get; }
    internal int[] Genes { get; set; }
    public Individual(Population pop) : this(pop, new int[pop.GenesCount])
    {
    }
    public Individual(Population pop, params int[] genes)
    {
        Population = pop;
        Genes = genes;
    }
    public void OnDying()
    {
        Handler?.Invoke(Color.Red);
    }
    public void OnSurvive()
    {
        Handler?.Invoke(Color.ForestGreen);
    }
    public void OnMutation()
    {
        Handler?.Invoke(Color.Yellow);
    }
    public override string ToString()
    {
        return string.Join("", Genes);
    }
}
