using FizzBuzz.Models;

namespace FizzBuzzTest.UnitTests.Helpers
{
    internal class Evaluator
    {
        private FizzBuzz.Helpers.Evaluator _evaluator;

        [TestCaseSource(nameof(SetUpConditionsValidCases))]
        public void SetUpConditionsDoesntThrowErrorWithValidValues(List<Condition> conditions)
        {
            Assert.DoesNotThrow(() => _evaluator.SetUpConditions(conditions));
        }

        [TestCaseSource(nameof(SetUpConditionsInvalidCases))]
        public void SetUpConditionsThrowsErrorWithInvalidValues(List<Condition> conditions)
        {
            Assert.Throws<InvalidDataException>(() => _evaluator.SetUpConditions(conditions));
        }

        [SetUp]
        public void Init()
        {
            _evaluator = new FizzBuzz.Helpers.Evaluator();
        }

        [TestCaseSource(nameof(EvaluatorCases))]
        public void EvaluateReturnsCorrectString(KeyValuePair<int, string> valueOutputPair)
        {
            Assert.That(_evaluator.Evaluate(valueOutputPair.Key), Is.EqualTo(valueOutputPair.Value));
        }

        [TestCaseSource(nameof(EvaluatorCases))]
        public void EvaluateWithConditionReturnsCorrectString(KeyValuePair<int, string> valueOutputPair)
        {
            Assert.That(_evaluator.EvaluateWithConditions(valueOutputPair.Key), Is.EqualTo(valueOutputPair.Value));
        }

        [TestCaseSource(nameof(EvaluatorCustomCases))]
        public void EvaluateWithCustomConditionsReturnsCorrectString(KeyValuePair<int, string> valueOutputPair)
        {
            _evaluator.SetUpConditions(customConditions);

            Assert.That(_evaluator.EvaluateWithConditions(valueOutputPair.Key), Is.EqualTo(valueOutputPair.Value));
        }

        // Test Data
        private static object[] SetUpConditionsValidCases =
        {
            new List<Condition>(),
            new List<Condition>()
            {
                new Condition(){Output = "Fizz", Value = 3}
            },
            new List<Condition>()
            {
                new Condition(){Output = "Fizz", Value = 3},
                new Condition(){Output = "Fizz", Value = 3}
            },
            new List<Condition>()
            {
                new Condition(){Output = "Fizz", Value = 3},
                new Condition(){Output = "BuzzFizz", Value = 51},
                new Condition(){Output = "FizzBuzz", Value = 15},
                new Condition(){Output = "Buzz", Value = 5},
                new Condition(){Output = "Zzif", Value = 33}
            }
        };

        private static object[] SetUpConditionsInvalidCases =
        {
            new List<Condition>()
            {
                new Condition(){Output = "Fizz", Value = 0}
            },
            new List<Condition>()
            {
                new Condition(){Output = "Fizz", Value = -3}
            },
            new List<Condition>()
            {
                new Condition(){Output = "Fizz", Value = 3},
                new Condition(){Output = "BuzzFizz", Value = 51},
                new Condition(){Output = "FizzBuzz", Value = 15},
                new Condition(){Output = "Buzz", Value = 5},
                new Condition(){Output = "Zzif", Value = 0}
            }
        };

        private static object[] EvaluatorCases =
        {
            new KeyValuePair<int,string>(3, "Fizz"),
            new KeyValuePair<int,string>(4, "4"),
            new KeyValuePair<int,string>(5, "Buzz"),
            new KeyValuePair<int,string>(6, "Fizz"),
            new KeyValuePair<int,string>(15, "FizzBuzz"),
            new KeyValuePair<int,string>(401, "401")
        };

        private static object[] EvaluatorCustomCases =
        {
            new KeyValuePair<int,string>(4, "Fizz"),
            new KeyValuePair<int,string>(5, "5"),
            new KeyValuePair<int,string>(7, "Buzz"),
            new KeyValuePair<int,string>(8, "Fizz"),
            new KeyValuePair<int,string>(28, "FizzBuzz"),
            new KeyValuePair<int,string>(401, "401")
        };

        private List<Condition> customConditions = new List<Condition>()
        {
            new Condition(){Output = "Fizz", Value = 4},
            new Condition(){Output = "Buzz", Value = 7},
            new Condition(){Output = "FizzBuzz", Value = 28}
        };
    }
}
