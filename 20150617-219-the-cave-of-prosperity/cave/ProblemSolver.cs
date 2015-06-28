using System.Linq;
using System.Collections.Generic;

namespace cave
{
    public class ProblemSolver
    {
        public State Solve(State initialState)
        {
            State bestSoFar = new State(0m);

            for (int i = 0; i < initialState.NuggetValues.Length; i++)
            {
                var selectedValue = initialState.NuggetValues[i];

                var possibilities = Possibilities(new[] { selectedValue }, initialState.NuggetValues.Except(new[] { selectedValue }), initialState.Capacity);

                foreach (var possibility in possibilities)
                {
                    if (possibility.Capacity > bestSoFar.Capacity)
                    {
                        bestSoFar = possibility;
                    }
                }
            }

            return bestSoFar;
        }

        public IEnumerable<State> Possibilities(IEnumerable<decimal> selected, IEnumerable<decimal> rest, decimal capacity)
        {
            List<State> allPossibilities = new List<State> { new State(selected.Sum(), selected.ToArray()) };

            foreach (var value in rest)
            {
                var capacitySoFar = selected.Sum();

                if (capacitySoFar + value <= capacity)
                {
                    allPossibilities.AddRange(Possibilities(selected.Union(new[] { value }), rest.Except(new[] { value }), capacity));
                }
            }

            return allPossibilities;
        }
    }
}