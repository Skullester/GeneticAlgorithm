namespace GeneticAlgorithm;

public class Pair
{
    public Individual First { get; }
    public Individual Second { get; }
    public static readonly IAction[] Actions;
    static Pair()
    {
        Actions = [new Dying(), new Survival(), new Mutation(), new Selection(), new Reset()];
    }
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

    private void Action(IAction action)
    {
        foreach (var ind in this)
            action.Act(ind);
    }
    public double TEST()
    {
        var sum = 0d;
        foreach (var ind in this)
        {
            sum += ind.Fitness;
        }
        return sum;
    }
    public void Kill()
    {
        Action(Actions[0]);
    }
    public void Survive()
    {
        Action(Actions[1]);
    }
    public void Mutate()
    {
        Action(Actions[2]);
    }

    public void Select()
    {
        Action(Actions[3]);
    }
    public void Reset()
    {
        Action(Actions[4]);
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
