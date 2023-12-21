using System.Windows.Forms.DataVisualization.Charting;

namespace GeneticAlgorithm;

public class Function
{
    private Chart visualizer;
    public Function(string function)
    {
        for (int i = 0; i < 10; i++)
        {
            visualizer.Series[0].Points.AddXY(1, 1);
        }
    }


}
