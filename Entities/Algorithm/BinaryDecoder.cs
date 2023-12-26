namespace GeneticAlgorithm;
public static class BinaryDecoder
{
    private static double Decode(string binariesStr)
    {
        return Convert.ToInt32(binariesStr, 2);
    }
    private static double Normalize(string binaryStr)
    {
        var value = Decode(binaryStr);
        double range = Fitness.MAX - Fitness.MIN;
        double normalizedValue = value / (Math.Pow(2, binaryStr.Length) - 1);
        return Fitness.MIN + normalizedValue * range;
    }
    public static Argument DecodeIndividual(Individual individual, int N)
    {
        double[] arguments = new double[N];
        var genes = individual.Genes;
        var genesStr = string.Join("", genes);
        var length = genesStr.Length / N;
        var startIndex = 0;
        //var endIndex = step;
        for (int i = 0; i < arguments.Length; i++)
        {
            var binaryStr = genesStr.Substring(startIndex, length);
            var x = Normalize(binaryStr);
            arguments[i] = x;
            startIndex += length;
        }
        return new Argument(arguments);
    }
}
