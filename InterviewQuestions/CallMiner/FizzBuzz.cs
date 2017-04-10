using System;

namespace InterviewQuestions
{
	// Only multiples of 3, 5, not others.
	// Make input integers of fizz and buzz
	public static class FizzBuzz
	{
		public static void GoFizzBuzz(this int[] theNumbers, int Fizz, int Buzz)
		{
			foreach (int i in theNumbers)
			{
				if (i % (Fizz * Buzz) == 0)
				{
					Console.WriteLine("FizzBuzz");
				}
				else if (i % Fizz == 0)
				{
					Console.WriteLine("Fizz");
				}
				else if (i % Buzz == 0)
				{
					Console.WriteLine("Buzz");
				}
				else
				{
					Console.WriteLine(i.ToString());
				}
			}
		}
	}
}
