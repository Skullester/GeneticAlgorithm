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
        geneticAlgorithm = new(this);
        InitializeComboBox();
        //   FitnessFunction func = new();
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
    public void UpdateText()
    {
        labelGeneration.Text = "Поколение: " + geneticAlgorithm.Generation + " Оптимум: " + Fitness.FitnessValue;
    }
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        field?.Life.Abort();
        geneticAlgorithm.Process.Interrupt();
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
        var genesCount = int.Parse(comboBoxCountOfGenes.Text);
        var indCount = int.Parse(comboBoxIndividuals.Text);
        geneticAlgorithm.Population = Population.GetRandomPopulation(genesCount, indCount);
        CreateField();
        MessageBox.Show("Популяция успешно создана!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

    }

    private void CreateField()
    {
        field = new Field(geneticAlgorithm.Population!, this);
    }

    private bool ValidateParameters()
    {
        var isValidated = geneticAlgorithm.Population is not null;
        if (!isValidated)
            MessageBox.Show("Сначала создайте изначальную популяцию!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return isValidated;
    }
    private void StartCrossover(object o, EventArgs e)
    {
        bool isValidated = ValidateParameters();
        if (isValidated)
            geneticAlgorithm.Process.Start();
    }

    private void Restart(object sender, EventArgs e)
    {
        Application.Restart();
    }
}