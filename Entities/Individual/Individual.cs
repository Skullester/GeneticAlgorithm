﻿using System.Collections;

namespace GeneticAlgorithm;

public class Individual : IEnumerable<int>
{
    public double Fitness { get; set; }
    public event Action<Color>? Handler;
    public Population Population { get; }
    internal int[] Genes { get; set; }
    public Individual(Population pop) : this(pop, new int[pop.GenesCount])
    {
    }
    public int this[int index]
    {
        get => Genes[index];
        set => Genes[index] = value;
    }
    public double GetFitness()
    {
        Fitness = GeneticAlgorithm.Fitness.GetFitness(this);
        return Fitness;
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
    public void OnReset()
    {
        Handler?.Invoke(Color.Black);
    }
    public override string ToString()
    {
        return string.Join("", Genes) + $" - {Fitness}";
    }

    public IEnumerator<int> GetEnumerator()
    {
        return ((IEnumerable<int>)Genes).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
