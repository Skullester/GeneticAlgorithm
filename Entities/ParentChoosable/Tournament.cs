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
            yield return new(ind, ind);
        }

        //foreach (var ind in map!)
        //{
        //    var index = rand.Next(0, map.Count);
        //    map.
        //    yield return (ind, partner);
        //}
    }
    public override string ToString()
    {
        return $"Турнирный отбор (t = {t})";
    }
}
