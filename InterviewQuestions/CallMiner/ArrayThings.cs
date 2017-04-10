using System;
namespace InterviewQuestions
{
	// Sorting to make this faster?
	public static class ArrayThings
	{
		public static bool ContainsSum(this int[] theNumbers, int theResult)
		{
			bool foundSum = false;
			Array.Sort(theNumbers);
			for (int i = 0; i < theNumbers.Length; i++)
			{
				int pos = i + 1;
				if ((i + 1) >= theNumbers.Length) { pos = 0; }
				int tSum = theNumbers[i] + theNumbers[pos];
				if (tSum == theResult)
				{
					foundSum = true;
					Console.WriteLine("ContainsSum iteration count was: {0}.", i);
					break;
				}
			}

			return foundSum;
		}

	}
}
