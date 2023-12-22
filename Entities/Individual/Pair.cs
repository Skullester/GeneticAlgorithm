namespace GeneticAlgorithm;

public class Pair
{
    private Random random = new Random();
    public Individual First { get; }
    public Individual Second { get; }
    public Pair((Individual, Individual) pairTuple)
    {
        First = pairTuple.Item1;
        Second = pairTuple.Item2;
    }
    public Pair(Individual first, Individual second)
    {
        First = first;
        Second = second;
    }
    public Pair(List<Individual> list)
    {
        if (list.Count != 2) throw new ArgumentException();
        First = list[0];
        Second = list[1];
    }

    enum Actions
    {
        Die, Mutate, Survive, Reset, Fitness
    }
    private void Action(Actions action)
    {
        foreach (var ind in this)
        {
            if (action is Actions.Die)
                ind.OnDying();
            else if (action is Actions.Mutate)
            {
                if (random.NextDouble() < 0.2)
                {
                    ind[0] = ind[0] == 1 ? 0 : 1;
                    ind.OnMutation();
                }
            }
            else if (action is Actions.Reset)
                ind.OnReset();
            else if (action is Actions.Fitness)
                ind.Fitness = Fitness.GetFitness(ind);
            else ind.OnSurvive();
        }
    }
    public void Fitnes()
    {
        Action(Actions.Fitness);
    }
    public void Reset()
    {
        Action(Actions.Reset);
    }
    public void Mutate()
    {
        Action(Actions.Mutate);
    }
    public void Kill()
    {
        Action(Actions.Die);
    }
    public void Survive()
    {
        Action(Actions.Survive);
    }
    public Individual this[int index]
    {
        get
        {
            return index switch
            {
                0 => First,
                1 => Second,
                _ => throw new IndexOutOfRangeException(),
            };
        }
    }
    public IEnumerator<Individual> GetEnumerator()
    {
        yield return First;
        yield return Second;
    }
    public override string ToString()
    {
        return $"{First}|{Second}";
    }
}
