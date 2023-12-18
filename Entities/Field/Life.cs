
namespace GeneticAlgorithm;

public class Life
{

    private readonly Thread life;
    private readonly Field field;

    public Life(Field field)
    {
        this.field = field;
        life = new(StartLife);
        life.Start();
    }
    public void Abort()
    {
        life.Interrupt();
    }
    public void StartLife()
    {
        Random random = new Random();
        while (true)
        {
            foreach (var cell in field.Cells)
            {
                var size = random.Next(0, 50);
                cell.Shake(new Size(size, size));
            }
            Thread.Sleep(200);
        }
    }
}
