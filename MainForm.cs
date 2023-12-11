namespace GeneticAlgorithm;

public partial class MainForm : Form
{
    private readonly Algorithm geneticAlgorithm;
    private Field? field;
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
        comboBoxParents.Items.AddRange([new Panmixia(geneticAlgorithm), new Inbreeding(geneticAlgorithm), new Outbreeding(geneticAlgorithm), new Tournament(geneticAlgorithm)]);
        comboBoxRecombinations.Items.AddRange([
            // new Discrete(),
            new Crossover(),
            new Intermediate()]);
        // new Linear()]);
    }
    private void OnComboBoxParentValueChanged(object? o, EventArgs e)
    {
        geneticAlgorithm.ParentChoosable = comboBoxParents.SelectedItem as ParentChoosing;
    }
    private void OnComboBoxRecombinationValueChanged(object? o, EventArgs e)
    {
        geneticAlgorithm.RecombinationChoosable = comboBoxParents.SelectedItem as IRecombinationChoosable;
    }
    private void GeneratePopulation(object sender, EventArgs e)
    {
        bool isValidated = ValidateParameters();
        if (!isValidated)
        {
            MessageBox.Show("Укажите параметры популяции!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        var genesCount = int.Parse(comboBoxCountOfGenes.Text);
        geneticAlgorithm.Population = Population.GetRandomPopulation(genesCount);
        MessageBox.Show("Популяция успешно создана!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    private bool ValidateParameters()
    {
        return !(comboBoxCountOfGenes.SelectedItem is null || comboBoxParents.SelectedItem is null || comboBoxRecombinations.SelectedItem is null);
    }
    private void StartCrossover(object o, EventArgs e)
    {
        geneticAlgorithm.Fitness = comboBoxMaxMin.Text == "Макс";
        geneticAlgorithm.Start();
    }
}
