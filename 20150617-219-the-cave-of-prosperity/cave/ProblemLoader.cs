using System.IO;
using System.Collections.Generic;

namespace cave
{
	public class ProblemLoader
	{
		public State Load(string filename) 
		{
			using (var streamReader = File.OpenText(filename))
			{
				var capacity = decimal.Parse(streamReader.ReadLine());
				var numberOfNuggets = int.Parse(streamReader.ReadLine());
				var nuggetsList = new List<decimal>();
				
				for(int i = 0; i < numberOfNuggets; i++) 
				{
					nuggetsList.Add(decimal.Parse(streamReader.ReadLine()));	
				}
				
				return new State(capacity, nuggetsList.ToArray());
			}
		}
	}	
}