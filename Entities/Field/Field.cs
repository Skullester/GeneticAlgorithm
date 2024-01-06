namespace GeneticAlgorithm;

public class Field
{
    private readonly static Color[] colors;
    private readonly MainForm form;
    public Cell[,]? Cells { get; private set; }
    public int Size { get; private set; }
    private readonly Population population;
    private TableLayoutPanel? fieldPanel;
    static Field()
    {
        colors = [Color.Black];
    }
    public Field(Population population, MainForm mainForm)
    {
        this.form = mainForm;
        this.population = population;
        FillField();
    }
    public Cell this[int row, int column]
    {
        get => Cells![row, column];
        set => Cells![row, column] = value;
    }
    private void InitializePanel()
    {
        fieldPanel = new TableLayoutPanel()
        {
            Size = new Size(600, 600),
            RowCount = Size,
            ColumnCount = Size,
            Location = new Point(580, 120)
        };
        if (form.Controls[^1] is TableLayoutPanel)
            form.Controls.RemoveAt(form.Controls.Count - 1);
        form.Controls.Add(fieldPanel);
        for (int i = 0; i < Size; i++)
        {
            fieldPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
            fieldPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
        }
    }
    private void FillField()
    {
        Random rand = new();
        Size = (int)Math.Sqrt(population.Count);
        InitializePanel();
        Cells = new Cell[Size, Size];
        int popIndex = 0;
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                var index = rand.Next(0, colors.Length);
                var button = new Button()
                {
                    BackColor = colors[index],
                    Enabled = false
                };
                var cell = new Cell(population[popIndex++], button);
                fieldPanel!.Controls.Add(button);
                this[i, j] = cell;
            }
        }
    }
}
