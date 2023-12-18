using System.Windows.Forms;

namespace GeneticAlgorithm;

public class Field
{
    private readonly static Color[] colors;
    private readonly MainForm form;
    public Life Life { get; private set; }
    public Cell[,] Cells { get; private set; }
    public int Size { get; private set; }
    private readonly Population population;
    private TableLayoutPanel? fieldPanel;
    static Field()
    {
        colors = [Color.DarkGreen, Color.Green, Color.LawnGreen];
    }
    public Field(Population population, MainForm mainForm)
    {
        this.form = mainForm;
        this.population = population;
        FillField();
    }
    public Cell this[int row, int column]
    {
        get => Cells[row, column];
        set => Cells[row, column] = value;
    }
    private void InitializePanel()
    {
        fieldPanel = new TableLayoutPanel();
        fieldPanel.Size = new Size(600, 600);
        if (form.Controls[form.Controls.Count - 1] is TableLayoutPanel)
            form.Controls.RemoveAt(form.Controls.Count - 1);
        form.Controls.Add(fieldPanel);
        fieldPanel.RowCount = Size;
        fieldPanel.ColumnCount = Size;
        for (int i = 0; i < Size; i++)
        {
            fieldPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            fieldPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        }
        fieldPanel.Location = new Point(580, 120);
    }
    private void FillField()
    {
        //при квадрате смысл во второй координате отсутствует
        Random rand = new();
        Size = (int)Math.Sqrt(population.Count);
        InitializePanel();
        Cells = new Cell[Size, Size];
        int popIndex = 0;
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                var button = new Button();
                var index = rand.Next(0, colors.Length);
                button.BackColor = colors[index];
                button.Enabled = false;
                var cell = new Cell(population[popIndex++], button);
                fieldPanel!.Controls.Add(button);
                this[i, j] = cell;
            }
        }
        Life = new(this);
    }
}
