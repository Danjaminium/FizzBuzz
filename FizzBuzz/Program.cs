using FizzBuzz.Helpers;
using FizzBuzz.Models;

namespace FizzBuzz
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            var evaluator = new Evaluator();

            try
            {
                evaluator.SetUpConditions(new List<Condition>()
            {
                new Condition(){Output = "Fizz", Value = 3},
                new Condition(){Output = "Buzz", Value = 5},
                new Condition(){Output = "FizzBuzz", Value = 15}
            });

                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine(evaluator.EvaluateWithConditions(i));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();

        }
    }
}