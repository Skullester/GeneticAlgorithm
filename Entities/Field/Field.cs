namespace GeneticAlgorithm;

public class Field
{
    private readonly Cell[,] cells;
    private readonly int sizeX;
    private readonly int sizeY;
    public Field()
    {
        cells = new Cell[sizeX, sizeY];
    }
    public Cell this[int i, int j]
    {
        get => cells[i, j];
        set => cells[i, j] = value;
    }
    private void FillField()
    {

    }

}
