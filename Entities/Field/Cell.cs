namespace GeneticAlgorithm;

public class Cell
{
    private readonly Individual individual;
    private Color color;
    public Button Button { get; }
    public Cell(Individual individual, Button button)
    {
        this.Button = button;
        this.individual = individual;
        individual.Handler += ChangeColor;
    }
    public void ChangeColor(Color color)
    {
        this.color = color;
        Button.BackColor = color;
    }

}
