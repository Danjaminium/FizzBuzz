namespace FizzBuzz.Helpers
{
    public class Evaluator
    {
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
    }
}
