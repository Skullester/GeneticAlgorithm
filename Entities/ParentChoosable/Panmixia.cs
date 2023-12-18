namespace GeneticAlgorithm;

public class Panmixia : ParentChoosing
{
    public Panmixia(Algorithm algorithm) : base(algorithm)
    {

    }
    public override IEnumerable<Pair> FindPartners()
    {
        var pop = Algorithm.Population;
        var count = pop!.Count;
        Random rand = new Random();
        foreach (var ind in pop!)
        {
            var index = rand.Next(0, count);
            var partner = pop[index];
            if (partner != ind)
                yield return new Pair((ind, partner));
        }
    }
    public override string ToString()
    {
        return "Панмиксия";
    }
}
