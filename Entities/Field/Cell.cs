namespace GeneticAlgorithm;

public class Cell
{
    private readonly Individual individual;
    private Color color;
    private readonly Button button;
    public Cell(Individual individual, Button button)
    {
        this.button = button;
        this.individual = individual;
        individual.Handler += ChangeColor;
    }
    public void ChangeColor(Color color)
    {
        this.color = color;
        button.ForeColor = color;
    }

}
