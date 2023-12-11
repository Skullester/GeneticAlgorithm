using System.Windows.Forms;

namespace GeneticAlgorithm;

public class Field
{
    private readonly MainForm form;
    private Cell[,] cells = null!;
    private int sizeX;
    private int sizeY;
    private readonly Population population;
    private TableLayoutPanel? fieldPanel;
    public Field(Population population, MainForm mainForm)
    {
        this.form = mainForm;
        this.population = population;
        FillField();
    }
    public Cell this[int row, int column]
    {
        get => cells[row, column];
        set => cells[row, column] = value;
    }
    private void InitializePanel()
    {
        fieldPanel = new TableLayoutPanel();
        fieldPanel.Size = new Size(500, 500);
        if (form.Controls[form.Controls.Count - 1] is TableLayoutPanel)
            form.Controls.RemoveAt(form.Controls.Count - 1);
        form.Controls.Add(fieldPanel);
        fieldPanel.RowCount = sizeX;
        fieldPanel.ColumnCount = sizeY;
        for (int i = 0; i < sizeX; i++)
        {
            fieldPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            fieldPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        }
        form.Hint.Visible = true;
        fieldPanel.Location = new Point(580, 150);
    }
    private void FillField()
    {
        sizeX = sizeY = (int)Math.Sqrt(population.Count);
        InitializePanel();
        cells = new Cell[sizeX, sizeY];
        int popIndex = 0;
        for (int i = 0; i < sizeX; i++)
        {
            for (int j = 0; j < sizeY; j++)
            {
                var button = new Button();
                button.BackColor = Color.Green;
                button.Enabled = false;
                var cell = new Cell(population[popIndex++], button);
                fieldPanel!.Controls.Add(button);
                this[i, j] = cell;
            }
        }
    }

}
