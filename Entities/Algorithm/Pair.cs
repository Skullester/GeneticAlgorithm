﻿namespace GeneticAlgorithm;

public class Pair
{
    public Individual First { get; }
    public Individual Second { get; }
    public Pair((Individual, Individual) pairTuple)
    {
        First = pairTuple.Item1;
        Second = pairTuple.Item2;
    }
    public Pair(Individual first, Individual second)
    {
        First = first;
        Second = second;
    }
    public Pair(List<Individual> list)
    {
        if (list.Count != 2) throw new ArgumentException();
        First = list[0];
        Second = list[1];
    }
    public Individual this[int index]
    {
        get
        {
            return index switch
            {
                0 => First,
                1 => Second,
                _ => throw new IndexOutOfRangeException(),
            };
        }
    }
    public IEnumerator<Individual> GetEnumerator()
    {
        yield return First;
        yield return Second;
    }
    public override string ToString()
    {
        return $"{First}|{Second}";
    }
}
