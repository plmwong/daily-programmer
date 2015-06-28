namespace cave
{
	public class State
	{
		public State(decimal capacity, params decimal[] nuggetValues)
		{
			Capacity = capacity;
			NuggetValues = nuggetValues;
		}
		
		public decimal Capacity { get; private set; }
		
		public decimal[] NuggetValues { get; private set; }
		
		public override string ToString()
		{
			return string.Format("Capacity: {0}, Nuggets: {1}", Capacity, string.Join(",", NuggetValues));
		}
	}
}