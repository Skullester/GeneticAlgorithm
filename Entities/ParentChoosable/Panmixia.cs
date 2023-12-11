namespace GeneticAlgorithm;

public class Panmixia : ParentChoosing
{
    public Panmixia(Algorithm algorithm) : base(algorithm)
    {

    }
    public override void SetPartners()
    {
        var pop = Algorithm.Population;
        var count = pop!.Count;
        Random rand = new Random();
        foreach (var ind in Algorithm.Population!)
        {
            var index = rand.Next(0, count + 1);
            if (pop[index] != ind)
                ind.Partner = pop[index];
        }
    }
    public override string ToString()
    {
        return "Панмиксия";
    }
}
