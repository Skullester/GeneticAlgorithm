namespace GeneticAlgorithm;

public partial class MainForm : Form
{
    private readonly Algorithm geneticAlgorithm;
    private Field? field;
    public Thread? AlgorithmThread { get; private set; }
    public MainForm()
    {
        InitializeComponent();
        geneticAlgorithm = new(this);
        Initialize();
    }

    private void Initialize()
    {
        comboBoxGenerations.SelectedValueChanged += OnGenerationsChanged;
        // checkBoxAccelerated.CheckedChanged += OnCheckBoxAccelerated;
        textBoxMutation.TextChanged += OnGenerationsChanged;
        comboBoxParents.Items.AddRange([new Panmixia(geneticAlgorithm), new Inbreeding(geneticAlgorithm), new Outbreeding(geneticAlgorithm), new Tournament(geneticAlgorithm), new Roulette(geneticAlgorithm)]);
        comboBoxRecombinations.Items.AddRange([new SingleCrossover(geneticAlgorithm), new DualCrossover(geneticAlgorithm)]);
        //comboBoxSpeed.SelectedValueChanged += OnComboBoxSpeedChanged;
        comboBoxParents.SelectedValueChanged += OnComboBoxParentValueChanged;
        comboBoxRecombinations.SelectedValueChanged += OnComboBoxRecombinationValueChanged;
        foreach (var item in Controls)
        {
            if (item is ComboBox cb)
                cb.SelectedIndex = 0;
        }
    }

    private void OnMutationChanged(object? o, EventArgs e)
    {
        var p = double.Parse(textBoxMutation.Text);
        if (p <= 0 || p > 1)
            throw new ArgumentException("Неверный ввод!");
        Algorithm.SetMutation(p);
    }

    private void OnGenerationsChanged(object? o, EventArgs e)
    {
        _ = int.TryParse(comboBoxGenerations.Text, out var gen);
        if (gen == 0)
            gen = int.MaxValue;
        geneticAlgorithm.MaxGenerations = gen;
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

    private void Reset()
    {
        AlgorithmThread = new(geneticAlgorithm.Start);
        AlgorithmThread.IsBackground = true;
        ListBoxArguments.Items.Clear();
    }

    private void GeneratePopulation()
    {
        Reset();
        SetAlgorithmFunction();
        Fitness.SetFunction(geneticAlgorithm.Function!);
        var genesCount = int.Parse(comboBoxCountOfGenes.Text);
        var indCount = int.Parse(comboBoxIndividuals.Text);
        geneticAlgorithm.Population = Population.GetRandomPopulation(genesCount, indCount);
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
        GeneratePopulation();
        bool isValidated = ValidateParameters();
        if (isValidated)
            AlgorithmThread!.Start();
    }

    public void Restart(object sender, EventArgs e)
    {
        Application.Restart();
    }
}