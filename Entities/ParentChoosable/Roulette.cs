namespace GeneticAlgorithm;

public class Roulette : ParentChoosing
{
    public Roulette(Algorithm algorithm) : base(algorithm)
    {
    }

    public override IEnumerable<(Individual, Individual)> FindPartners()
    {
        var rand = new Random();
        var pop = Algorithm.Population;
        var sum = pop.Sum(x => x.Value);
        var dic = new Dictionary<int, Individual>();
        foreach (var ind in pop)
        {
            var ratio = ind.Value / sum;
            dic[ratio] = ind;
        }


    }
    public override string ToString()
    {
        return "Рулеточный";
    }
}
