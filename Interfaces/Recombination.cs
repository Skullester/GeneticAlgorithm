namespace GeneticAlgorithm;

public abstract class Recombination
{
    protected const int pairCount = 2;
    protected Algorithm Algorithm { get; }
    protected Population Population => Algorithm.Population!;
    public abstract Pair Cross(Pair pair);
    protected Pair GetGap(Pair pair, int firstGap, int secondGap)
    {
        List<int[]> tails = new();
        for (int i = pairCount - 1; i > -1; i--)
        {
            var tail = pair[i].Genes[(firstGap + 1)..(secondGap + 1)];
            tails.Add(tail);
        }
        List<Individual> newIndividuals = new();
        for (int i = 0; i < pairCount; i++)
        {
            var head = pair[i].Genes[0..(firstGap + 1)];
            var gap = tails[i];
            int[] tail = pair[i].Genes[(secondGap + 1)..Population.GenesCount];
            var newArr = head.Concat(gap).Concat(tail).ToArray();
            pair[i].Genes = newArr;
            //  newIndividuals.Add(new Individual(Population, newArr));
        }
        return pair;
    }
    public Recombination(Algorithm algorithm)
    {
        Algorithm = algorithm;
    }
}
