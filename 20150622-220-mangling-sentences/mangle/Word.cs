using System.Collections.Generic;
using System.Linq;

public class Word
{
	public Word(string letters)
	{
		IsCapitalised= letters[0].IsCapitalLetter();
		Letters = letters.ToLowerInvariant();
		
		Punctuation = letters.Punctuation();
	}
	
	public string Letters { get; private set; }
	
	public bool IsCapitalised { get; private set; }
	
	public IEnumerable<NonWordCharacter> Punctuation { get; private set; }
	
	public string WordCharacters { 
		get 
		{
			return string.Concat(Letters.Where(l => l.IsWordLetter()));
		}
	}
	
}