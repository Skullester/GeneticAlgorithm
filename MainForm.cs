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
        comboBoxParents.Items.AddRange([new Panmixia(geneticAlgorithm), new Inbreeding(geneticAlgorithm), new Outbreeding(geneticAlgorithm), new Tournament(geneticAlgorithm), new Roulette(geneticAlgorithm)]);
        comboBoxRecombinations.Items.AddRange([new SingleCrossover(geneticAlgorithm), new DualCrossover(geneticAlgorithm)]);
        comboBoxSpeed.SelectedValueChanged += OnComboBoxSpeedChanged;
        comboBoxParents.SelectedValueChanged += OnComboBoxParentValueChanged;
        comboBoxRecombinations.SelectedValueChanged += OnComboBoxRecombinationValueChanged;
        foreach (var item in Controls)
        {
            if (item is ComboBox cb)
                cb.SelectedIndex = 0;
        }
    }
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        field?.Life.Abort();
    }
    private void OnComboBoxSpeedChanged(object? o, EventArgs e)
    {
        var multiplier = int.Parse((comboBoxSpeed.SelectedItem as string)!.Split('x')[1]);
        geneticAlgorithm.Speed = Algorithm.START_SPEED / multiplier;
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
        if (isValidated)
        {
            var genesCount = int.Parse(comboBoxCountOfGenes.Text);
            geneticAlgorithm.Population = Population.GetRandomPopulation(genesCount);
            CreateField();
            MessageBox.Show("ѕопул€ци€ успешно создана!", "”спешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void CreateField()
    {
        field = new Field(geneticAlgorithm.Population!, this);
    }

    private bool ValidateParameters(bool validator = false)
    {
        var isValidated = !(comboBoxCountOfGenes.SelectedItem is null || comboBoxParents.SelectedItem is null || comboBoxRecombinations.SelectedItem is null || validator);
        if (!isValidated)
            MessageBox.Show("—начала создайте изначальную попул€цию!", "ќшибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return isValidated;
    }
    private void StartCrossover(object o, EventArgs e)
    {
        bool isValidated = ValidateParameters(geneticAlgorithm.Population is null);
        if (isValidated)
            geneticAlgorithm.Process.Start();
    }

    private void Restart(object sender, EventArgs e)
    {
        Application.Restart();
    }
}