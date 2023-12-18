namespace GeneticAlgorithm;

public class Cell
{
    private readonly Individual individual;
    private Color color;
    private Button button { get; }
    public readonly Size DefaultSize;
    public Cell(Individual individual, Button button)
    {
        this.button = button;
        this.individual = individual;
        DefaultSize = button.ClientSize;
        individual.Handler += ChangeColor;
    }
    public void ChangeColor(Color color)
    {
        this.color = color;
        button.BackColor = color;
    }
    public void Shake(Size size)
    {
        button.Size = size;
    }
}
