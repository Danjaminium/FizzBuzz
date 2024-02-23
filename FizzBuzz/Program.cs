using FizzBuzz.Helpers;

namespace FizzBuzz
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            var evaluator = new Evaluator();

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(evaluator.Evaluate(i));
            }

            Console.ReadKey();

        }
    }
}