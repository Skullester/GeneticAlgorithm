namespace GeneticAlgorithm;

public class Tournament : ParentChoosing
{
    public const int t = 3;
    public Tournament(Algorithm algorithm) : base(algorithm)
    {

    }
    public override void SetPartners()
    {
        HashSet<Individual> map = new();
        var pop = Algorithm.Population;
        for (int i = 0; i < t; i++)
        {
            if (!map.Contains(pop![i])) ;
        }
    }
    public override string ToString()
    {
        return $"Турнирный отбор (t = {t})";
    }
}
