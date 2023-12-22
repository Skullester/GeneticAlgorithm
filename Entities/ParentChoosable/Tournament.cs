namespace GeneticAlgorithm;

public class Tournament : ParentChoosing
{
    private const int t = 2;
    public Tournament(Algorithm algorithm) : base(algorithm)
    {

    }
    public override IEnumerable<Pair> FindPartners()
    {
        HashSet<Individual> map = new();
        var rand = Algorithm.Random;
        foreach (var ind in Population)
        {
            List<Individual> candidates = new();
            for (int i = 0; i < t; i++)
            {
                var index = rand.Next(0, Population.Count);
                candidates.Add(Population[index]);
            }
            var bestCandidate = candidates.MinBy(x => x.Fitness);
            map.Add(bestCandidate!);
        }
        foreach (var ind in map!)
        {
            var index = rand.Next(0, map.Count);
            var partner = map.ElementAt(index);
            yield return new Pair((ind, partner));
        }
    }
    public override string ToString()
    {
        return $"Турнирный отбор (t = {t})";
    }
}
