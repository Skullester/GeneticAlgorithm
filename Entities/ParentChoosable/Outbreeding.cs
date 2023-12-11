namespace GeneticAlgorithm;
public class Outbreeding : ParentChoosing
{
    public Outbreeding(Algorithm algorithm) : base(algorithm)
    {

    }
    public override void SetPartners() => OrderBy(x => x.MaxBy(x => x.count).individ);
    public override string ToString()
    {
        return "Оутбридинг";
    }
}
