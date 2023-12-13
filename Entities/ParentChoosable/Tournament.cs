namespace GeneticAlgorithm;

public class Tournament : ParentChoosing
{
    private const int t = 2;
    public Tournament(Algorithm algorithm) : base(algorithm)
    {

    }
    public override IEnumerable<(Individual, Individual)> FindPartners()
    {
        HashSet<Individual> map = new();
        var pop = Algorithm.Population;
        var rand = new Random();
        foreach (var ind in pop!)
        {
            List<Individual> candidates = new();
            for (int i = 0; i < t; i++)
            {
                var index = rand.Next(0, pop.Count);
                candidates.Add(pop[index]);
            }
            var bestCandidate = candidates.MaxBy(x => x.Value);
            map.Add(bestCandidate!);
        }
        var isFirst = false;
        Individual? tmp = default!;
        foreach (var ind in map!)
        {
            if (isFirst)
                isFirst = false;
            else
                yield return (ind, tmp);
            tmp = ind;
        }
    }
    public override string ToString()
    {
        return $"Турнирный отбор (tournament = {t})";
    }
}
