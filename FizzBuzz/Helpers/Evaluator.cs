using FizzBuzz.Models;

namespace FizzBuzz.Helpers
{
    public class Evaluator
    {
        private List<Condition> _conditions = new List<Condition>()
        {
            new Condition(){Output = "FizzBuzz", Value = 15},
            new Condition(){Output = "Buzz", Value = 5},
            new Condition(){Output = "Fizz", Value = 3}
        };

        public void SetUpConditions(List<Condition> conditions)
        {
            this._conditions = conditions.OrderByDescending(c => c.Value).ToList();
        }

        // Itteration 1
        public string Evaluate(int valueToCheck)
        {
            if (valueToCheck % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if (valueToCheck % 5 == 0)
            {
                return "Buzz";
            }
            else if (valueToCheck % 3 == 0)
            {
                return "Fizz";
            }
            else
            {
                return valueToCheck.ToString();
            }
        }

        // Itteration 2
        public string EvaluateWithConditions(int valueToCheck)
        {
            return this._conditions.FirstOrDefault(c => valueToCheck % c.Value == 0)?.Output ?? valueToCheck.ToString();
        }
    }
}
