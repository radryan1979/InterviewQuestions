using System;
using System.Collections.Generic;

namespace InterviewQuestions
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] someNumbers = new int[100];
			int i = 0;
			while (i < 100)
			{
				someNumbers[i] = i;
				i++;
			}

			someNumbers.GoFizzBuzz(3,5);

			bool sumFound = someNumbers.ContainsSum(99);
			Console.WriteLine("Did we find a sum in the list? {0}", sumFound.ToString());

			List<string> words = new List<string>()
			{
				"racecar",
				"alula",
				"anna",
				"andover",
				"avid diva",
				"boob",
				"barb",
				"civic",

			};


			foreach (string aWord in words)
			{
				bool isIt = aWord.IsPalindrome();
				if (isIt) { Console.WriteLine("The word {0} is a palindrome.", aWord); }
				if (!isIt) { Console.WriteLine("The word {0} is not a palindrome.", aWord); }
			}

			Console.ReadKey();
		}
	}
}
