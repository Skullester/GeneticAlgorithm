namespace GeneticAlgorithm;
public class Outbreeding : ParentChoosing
{
    public Outbreeding(Algorithm algorithm) : base(algorithm)
    {

    }
    public override void FindPartners() => GetParents(x => x.MaxBy(x => x.count).individ);
    public override string ToString()
    {
        return "Оутбридинг";
    }
}
