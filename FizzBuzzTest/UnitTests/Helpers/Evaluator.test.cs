namespace FizzBuzzTest.UnitTests.Helpers
{
    internal class Evaluator
    {
        [TestCase(4, "4")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(6, "Fizz")]
        [TestCase(401, "401")]
        public void EvaluateReturnsCorrectString(int valueToCheck, string expectedReturn)
        {
            var evaluator = new FizzBuzz.Helpers.Evaluator();

            Assert.That(evaluator.Evaluate(valueToCheck), Is.EqualTo(expectedReturn));
        }

        [TestCase(4, "4")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(6, "Fizz")]
        [TestCase(401, "401")]
        public void EvaluateWithConditionReturnsCorrectString(int valueToCheck, string expectedReturn)
        {
            var evaluator = new FizzBuzz.Helpers.Evaluator();

            Assert.That(evaluator.EvaluateWithConditions(valueToCheck), Is.EqualTo(expectedReturn));
        }
    }
}
