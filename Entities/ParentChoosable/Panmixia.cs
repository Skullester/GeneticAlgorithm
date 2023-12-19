namespace GeneticAlgorithm;

public class Panmixia : ParentChoosing
{
    public Panmixia(Algorithm algorithm) : base(algorithm)
    {

    }
    public override IEnumerable<Pair> FindPartners()
    {
        var count = Population!.Count;
        Random rand = Algorithm.Random;
        foreach (var ind in Population!)
        {
            var index = rand.Next(0, count);
            var partner = Population[index];
            if (partner != ind)
                yield return new Pair((ind, partner));
        }
    }
    public override string ToString()
    {
        return "Панмиксия";
    }
}
