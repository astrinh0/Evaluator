namespace Evaluator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Evaluator<int> evaluator = new Evaluator<int>();

            evaluator.Add((val, additionalVals) => val / 2);
            evaluator.Add((val, additionalVals) => val + additionalVals[0], 5);
            evaluator.Add((val, additionalVals) => val + 1 + additionalVals[0], 20);
            evaluator.Add((val, additionalVals) => val - additionalVals[0] - additionalVals[1], 5, 3);

            Console.WriteLine(evaluator.Evaluate(8));
        }
    }
}