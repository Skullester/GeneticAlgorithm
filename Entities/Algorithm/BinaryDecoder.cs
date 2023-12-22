using System.Text;

namespace GeneticAlgorithm;
public static class BinaryDecoder
{
    private static double Decode(string binariesStr)
    {
        return Convert.ToInt32(binariesStr, 2);
    }
    public static double Normalize(double max, double min, string binaryStr)
    {
        var value = Decode(binaryStr);
        double range = max - min;
        double normalizedValue = value / (Math.Pow(2, binaryStr.Length) - 1); // Normalize binary value
        return min + normalizedValue * range;
    }
}
