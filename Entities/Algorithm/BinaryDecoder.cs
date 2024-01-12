namespace GeneticAlgorithm;
public static class BinaryDecoder
{
    private static double Decode(string binariesStr)
    {
        return Convert.ToInt64(binariesStr, 2);
    }
    private static double Normalize(string binaryStr)
    {
        var value = Decode(binaryStr);
        double range = Fitness.Max - Fitness.Min;
        double normalizedValue = value / (Math.Pow(2, binaryStr.Length) - 1);
        return Fitness.Min + normalizedValue * range;
    }
    public static Argument DecodeIndividual(Individual individual, int N)
    {
        double[] arguments = new double[N];
        var genes = individual.Genes;
        var genesStr = string.Join("", genes);
        var length = genesStr.Length / N;
        var startIndex = 0;
        for (int i = 0; i < N; i++)
        {
            var binaryStr = genesStr.Substring(startIndex, length);
            var x = Normalize(binaryStr);
            arguments[i] = x;
            startIndex += length;
        }
        return new Argument(arguments);
    }
}
