namespace GeneticAlgorithm;

public class Cell
{
    private Button button { get; }
    public Cell(Individual individual, Button button)
    {
        this.button = button;
        // this.individual = individual;
        //  DefaultSize = button.ClientSize;
        individual.Handler += ChangeColor;
    }
    public void ChangeColor(Color color)
    {
        button.BackColor = color;
    }
    public void Shake(Size size)
    {
        //button.ClientSize = size;
    }
}
