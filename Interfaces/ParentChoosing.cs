namespace GeneticAlgorithm;

public abstract class ParentChoosing
{
    protected Algorithm Algorithm { get; }
    protected Population Population => Algorithm.Population!;
    public ParentChoosing(Algorithm algorithm)
    {
        Algorithm = algorithm;
    }
    public abstract IEnumerable<Pair> FindPartners();

    protected IEnumerable<Pair> GetParents(Func<IEnumerable<(int count, Individual individ)>, Individual> selector)
    {
        foreach (var ind in Population!)
        {
            var tupleEnum = Population
            .Where(indiv => indiv != ind)
            .Select(x => (count: x.Genes.Where((x, index) => ind.Genes[index] != x).Count(), individ: x));
            var secondInd = selector(tupleEnum);
            yield return new Pair((ind, secondInd));
        }
    }
}
