using System.Collections;

namespace GeneticAlgorithm;

public class Roulette : ParentChoosing
{
    private class Segment
    {
        public float Start { get; set; }
        public float End { get; set; }
        public Segment(float start, float end)
        {
            Start = start;
            End = end;
        }
        public override string ToString()
        {
            return $"{Start} - {End}";
        }
    }
    public Roulette(Algorithm algorithm) : base(algorithm)
    {
    }

    public override IEnumerable<(Individual, Individual)> FindPartners()
    {
        var rand = new Random();
        var pop = Algorithm.Population;
        float sum = pop!.Sum(x => x.Value);
        var dic = new Dictionary<Segment, Individual>();
        float num = 0;
        foreach (var ind in pop!)
        {
            float ratio = ind.Value / sum;
            Segment seg = new(num, num += ratio);
            dic[seg] = ind;
        }
        var parents = new List<Individual>();
        for (int i = 0; i < pop.Count; i++)
        {
            foreach (var item in dic)
            {
                var seg = item.Key;
                var numb = rand.NextDouble();
                if (seg.Start <= numb && numb <= seg.End)
                    parents.Add(item.Value);
            }
        }
        foreach (var ind in parents)
        {
            var index = rand.Next(0, parents.Count);
            var partner = pop[index];
            if (partner != ind)
                yield return new(ind, partner);
        }
    }
    public override string ToString()
    {
        return "Рулеточный";
    }
}
