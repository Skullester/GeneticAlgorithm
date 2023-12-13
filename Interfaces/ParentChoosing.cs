using System.Collections.Generic;

namespace GeneticAlgorithm;

public abstract class ParentChoosing
{
    protected Algorithm Algorithm { get; }
    public ParentChoosing(Algorithm algorithm)
    {
        Algorithm = algorithm;
    }
    public abstract IEnumerable<(Individual, Individual)> FindPartners();

    protected IEnumerable<(Individual, Individual)> GetParents(Func<IEnumerable<(int count, Individual individ)>, Individual> selector)
    {
        var pop = Algorithm.Population;
        foreach (var ind in pop!)
        {
            var tupleEnum = pop
            .Where(indiv => indiv != ind)
            .Select(x => (count: x.Genes
              .Where((x, index) => ind.Genes[index] != x)
              .Count(), individ: x));
            var secondInd = selector(tupleEnum);
            yield return (ind, secondInd);
        }
    }
}
