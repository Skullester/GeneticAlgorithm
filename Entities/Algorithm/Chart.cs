using WinChart = System.Windows.Forms.DataVisualization.Charting.Chart;

namespace GeneticAlgorithm;

public class Chart
{
    private readonly WinChart visualizer;
    public Chart(WinChart chart)
    {
        visualizer = chart;
    }
    public void Draw(double x, double y)
    {
        visualizer.Series[0].Points.AddXY(x, y);
    }
}
