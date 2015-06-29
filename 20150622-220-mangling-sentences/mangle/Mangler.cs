using System.Linq;

public class Mangler
{
	public string Mangle(string input)
	{
		var words = input.Split(' ');
		
		var mangledWords = words.Select(w => MangleLetters(w));
		
		return string.Join(" ", mangledWords);;
	}
	
	private string MangleLetters(string letters)
	{
		var word = new Word(letters);
		
		var mangledWord = word.WordCharacters.OrderBy(w => w).ToList();
		
		foreach(var punctuation in word.Punctuation.OrderBy(p => p.Position))
		{
			mangledWord.Insert(punctuation.Position, punctuation.Character);
		}
		
		if (word.IsCapitalised)
		{
			mangledWord[0] = char.ToUpperInvariant(mangledWord[0]);
		}
		
		return string.Concat(mangledWord);
	}
}