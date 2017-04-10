using System;
namespace InterviewQuestions
{
	public static class Palindrome
	{
		public static bool IsPalindrome(this string word)
		{
			bool isPalidrome = true;
			int l = word.Length;
			int k = l - 1;
			Console.WriteLine("Word length is: {0}.", l);

			for (int i = 0; i < l; i++)
			{
				if (i == (l - i)) { break; }
				char left = word[i];
				char right = word[k];
				if (word[i] != word[k-i]) { isPalidrome = false; }
			}

			return isPalidrome;
		}
	}
}
