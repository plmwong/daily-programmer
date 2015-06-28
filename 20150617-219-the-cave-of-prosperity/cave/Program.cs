using System;

namespace cave
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var problemDefinitionFile = args[0];
            Console.WriteLine("Reading problem from definition file '{0}'", problemDefinitionFile);
            
            var problemLoader = new ProblemLoader();
            var problemState = problemLoader.Load(problemDefinitionFile);
            
            Console.WriteLine("Problem loaded, initial state: '{0}'", problemState.ToString());
            
            var problemSolver = new ProblemSolver();
            var solution = problemSolver.Solve(problemState);
            
            Console.WriteLine("Solution: '{0}'", solution.ToString());
        }
    }
}
