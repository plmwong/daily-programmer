public class NonWordCharacter
{
	public NonWordCharacter(char character, int position)
	{
		Character = character;
		Position = position;
	}
	
	public char Character { get; private set; }
	public int Position { get; private set; }
}