using System.Linq;
using System.Collections.Generic;

public static class WordExtensions
{
	private static readonly string _capitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
	private static readonly string _lowerLetters = "abcdefghijklmnopqrstuvwxyz";
	private static readonly string _wordLetters = _capitalLetters + _lowerLetters;
	
	public static bool IsCapitalLetter(this char letter)
	{
		return _capitalLetters.Contains(letter);
	}
	
	public static bool IsWordLetter(this char letter)
	{
		return _wordLetters.Contains(letter);
	}
	
	public static IEnumerable<NonWordCharacter> Punctuation(this string word)
	{
		for(int i = 0; i < word.Length; i++)
		{
			if (!_wordLetters.Contains(word[i]))
			{
				yield return new NonWordCharacter(word[i], i);
			}
		}
	}
}