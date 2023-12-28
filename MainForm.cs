using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Timer = System.Windows.Forms.Timer;

namespace GeneticAlgorithm;

public partial class MainForm : Form
{
    private readonly Algorithm geneticAlgorithm;
    private Field? field;
    //private readonly Timer timer = new();
    public MainForm()
    {
        InitializeComponent();
        geneticAlgorithm = new(this);
        Initialize();
    }
    private void Initialize()
    {
        checkBoxAccelerated.CheckedChanged += OnCheckBoxAccelerated;
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
        labelGeneration.Text = "���������: " + geneticAlgorithm.Generation + " �������: " + Fitness.FitnessValue;
    }
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        // field?.Life.Abort();
        geneticAlgorithm.Process.Interrupt();
    }
    private void OnComboBoxSpeedChanged(object? o, EventArgs e)
    {
        var multiplier = int.Parse((comboBoxSpeed.SelectedItem as string)!.Split('x')[1]);
        geneticAlgorithm.Multiplier = multiplier;
        geneticAlgorithm.SetSpeed();
    }
    private void OnCheckBoxAccelerated(object? o, EventArgs e)
    {
        geneticAlgorithm.SetSpeed();
    }
    private void OnComboBoxParentValueChanged(object? o, EventArgs e)
    {
        geneticAlgorithm.ParentChoosable = comboBoxParents.SelectedItem as ParentChoosing;
    }
    private void OnComboBoxRecombinationValueChanged(object? o, EventArgs e)
    {
        geneticAlgorithm.Recombination = comboBoxRecombinations.SelectedItem as Recombination;
    }
    private void SetAlgorithmFunction()
    {
        var N = int.Parse(comboBoxDimensions.Text);
        geneticAlgorithm.Function = new Rastrigin(10, N);
    }
    private void GeneratePopulation(object sender, EventArgs e)
    {
        SetAlgorithmFunction();
        Fitness.SetFunction(geneticAlgorithm.Function!);
        var genesCount = int.Parse(comboBoxCountOfGenes.Text);
        var indCount = int.Parse(comboBoxIndividuals.Text);
        geneticAlgorithm.Population = Population.GetRandomPopulation(genesCount, indCount);
        // CreateField();
        MessageBox.Show("��������� ������� �������!", "�������!", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void CreateField()
    {
        field = new Field(geneticAlgorithm.Population!, this);
    }

    private bool ValidateParameters()
    {
        var isValidated = geneticAlgorithm.Population is not null;
        if (!isValidated)
            MessageBox.Show("������� �������� ����������� ���������!", "������!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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