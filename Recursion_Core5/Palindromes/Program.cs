/*
 * Chosen algorithm: https://w3resource.com/csharp-exercises/recursion/csharp-recursion-exercise-14.php
 */

using System;

namespace Palindromes {
	class Program {
		static void Main() {
			Console.Write("Enter a word/phrase to see if it's a palindrome: ");

			string promptText = Console.ReadLine();
			string finalText = "";

			foreach (char s in promptText) if (!char.IsPunctuation(s) && !char.IsWhiteSpace(s)) finalText += s.ToString().ToLower();

			promptText = finalText;

			finalText = recursive(finalText);

			Console.WriteLine($"\n\nThe word/phrase you entered is a palindrome : {promptText == finalText}\n");
		}

		static string recursive(string finalText) {
			if (finalText.Length > 0) return finalText[finalText.Length - 1] + recursive(finalText.Substring(0, finalText.Length - 1));
			else return finalText;
		}
	}
}