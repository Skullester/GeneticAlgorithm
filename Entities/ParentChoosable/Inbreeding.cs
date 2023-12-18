namespace GeneticAlgorithm;

public class Inbreeding : ParentChoosing
{
    public Inbreeding(Algorithm algorithm) : base(algorithm)
    {

    }
    public override IEnumerable<Pair> FindPartners() => GetParents(x => x.MinBy(x => x.count).individ);
    public override string ToString()
    {
        return "Инбридинг";
    }
}
