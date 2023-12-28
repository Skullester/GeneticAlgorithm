namespace GeneticAlgorithm;

public class Life
{
    private readonly Thread cycle;
    private readonly Field field;
    public Life(Field field)
    {
        this.field = field;
        cycle = new(StartLife);
        cycle.Start();
    }
    public void Abort()
    {
        cycle.Interrupt();
    }
    public void StartLife()
    {
        Random random = new();
        while (true)
        {
            var row = random.Next(1, field.Size);
            var column = random.Next(1, field.Size);
            var cell = field[row, column];
            var size = random.Next(10, 20);
            cell.Shake(new Size(size, size));
            Thread.Sleep(100);
        }
    }
}
