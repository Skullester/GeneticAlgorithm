namespace GeneticAlgorithm;

public abstract class Recombination
{
    protected const int pairCount = 2;
    protected Algorithm Algorithm { get; }
    protected Population Population => Algorithm.Population!;
    public abstract Pair Cross(Pair pair);
    public Recombination(Algorithm algorithm)
    {
        Algorithm = algorithm;
    }
    protected Pair GetGap(Pair pair, int firstGap, int secondGap)
    {
        Individual first = pair[0];
        Individual second = pair[1];
        List<int[]> oldGenes = new() { first.Genes, second.Genes };
        double[] oldFitnesses = { first.Fitness, second.Fitness };

        List<int[]> tails = new();
        for (int i = pairCount - 1; i > -1; i--)
        {
            var tail = pair[i].Genes[(firstGap + 1)..(secondGap + 1)];
            tails.Add(tail);
        }
        for (int i = 0; i < pairCount; i++)
        {
            var head = pair[i].Genes[0..(firstGap + 1)];
            var gap = tails[i];
            int[] tail = pair[i].Genes[(secondGap + 1)..Population.GenesCount];
            var newArr = head.Concat(gap).Concat(tail).ToArray();
            pair[i].Genes = newArr;
        }
        for (int i = 0; i < pairCount; i++)
        {
            pair[i].GetFitness();
            if (pair[i].Fitness > oldFitnesses[i])
                pair[i].Genes = oldGenes[i];
            else pair[i].OnDying();
        }
        return pair;
    }

}
