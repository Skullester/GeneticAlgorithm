using System.Collections;

namespace GeneticAlgorithm;

public class Roulette : ParentChoosing
{
    private class Segment
    {
        public double Start { get; set; }
        public double End { get; set; }
        public Segment(double start, double end)
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

    public override IEnumerable<Pair> FindPartners()
    {
        var rand = Algorithm.Random;
        var sum = Population!.Sum(x => x.Fitness);
        var dic = new Dictionary<Segment, Individual>();
        double num = 0;
        foreach (var ind in Population!)
        {
            var ratio = ind.Fitness / sum;
            Segment seg = new(num, num += ratio);
            dic[seg] = ind;
        }
        var parents = new List<Individual>();
        for (int i = 0; i < Population.Count; i++)
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
            var partner = parents[index];
            if (partner != ind)
                yield return new Pair((ind, partner));
        }
    }
    public override string ToString()
    {
        return "Рулеточный";
    }
}
