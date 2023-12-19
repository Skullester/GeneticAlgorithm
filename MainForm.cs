using Timer = System.Windows.Forms.Timer;

namespace GeneticAlgorithm;

public partial class MainForm : Form
{
    private readonly Algorithm geneticAlgorithm;
    private Field? field;
    private readonly Timer timer = new();
    public MainForm()
    {
        InitializeComponent();
        geneticAlgorithm = new();
        InitializeComboBox();
    }
    private void InitializeComboBox()
    {

        comboBoxParents.SelectedValueChanged += OnComboBoxParentValueChanged;
        comboBoxRecombinations.SelectedValueChanged += OnComboBoxRecombinationValueChanged;
        comboBoxParents.Items.AddRange([new Panmixia(geneticAlgorithm), new Inbreeding(geneticAlgorithm), new Outbreeding(geneticAlgorithm), new Tournament(geneticAlgorithm), new Roulette(geneticAlgorithm)]);
        comboBoxRecombinations.Items.AddRange([new SingleCrossover(geneticAlgorithm), new DualCrossover(geneticAlgorithm)]);
    }
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        field?.Life.Abort();
    }
    private void OnComboBoxParentValueChanged(object? o, EventArgs e)
    {
        geneticAlgorithm.ParentChoosable = comboBoxParents.SelectedItem as ParentChoosing;
    }
    private void OnComboBoxRecombinationValueChanged(object? o, EventArgs e)
    {
        geneticAlgorithm.Recombination = comboBoxRecombinations.SelectedItem as Recombination;
    }
    private void GeneratePopulation(object sender, EventArgs e)
    {
        bool isValidated = ValidateParameters();
        if (!isValidated)
        {
            MessageBox.Show("”кажите параметры попул€ции!", "ќшибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        var genesCount = int.Parse(comboBoxCountOfGenes.Text);
        geneticAlgorithm.Population = Population.GetRandomPopulation(genesCount);
        CreateField();
        MessageBox.Show("ѕопул€ци€ успешно создана!", "”спешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void CreateField()
    {
        field = new Field(geneticAlgorithm.Population!, this);
    }

    private bool ValidateParameters()
    {
        return !(comboBoxCountOfGenes.SelectedItem is null || comboBoxParents.SelectedItem is null || comboBoxRecombinations.SelectedItem is null);
    }
    private void StartCrossover(object o, EventArgs e)
    {
        geneticAlgorithm.Process.Start();
    }
}
