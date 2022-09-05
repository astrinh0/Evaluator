namespace Evaluator.Tests
{
    using Xunit;

    public class EvaluatorTests
    {
        [Fact]
        public void Evaluator_Evaluate_Success_Return22()
        {
            //Arrange

            var evaluator = new Evaluator<int>();

            evaluator.Add((val, additionalVals) => val / 2);
            evaluator.Add((val, additionalVals) => val + additionalVals[0], 5);
            evaluator.Add((val, additionalVals) => val + 1 + additionalVals[0], 20);
            evaluator.Add((val, additionalVals) => val - additionalVals[0] - additionalVals[1], 5, 3);

            var expectedResult = 22;
            var input = 8;

            //Act

            var result = evaluator.Evaluate(input);

            //Assert

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Evaluator_Evaluate_Success_ReturnNull()
        {
            //Arrange

            var evaluator = new Evaluator<int?>();

            var expectedResult = "Input value is null!";

            //Act

            var result = evaluator.HasValue(evaluator.Evaluate(null));

            //Assert

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Evaluator_Evaluate_Success_ReturnObject()
        {
            //Arrange

            var evaluator = new Evaluator<object>();

            var expectedResult = new object();
            var input = new object();

            //Act

            var result = evaluator.Evaluate(input);

            //Assert

            Assert.NotStrictEqual(expectedResult, result);
        }
    }
}
