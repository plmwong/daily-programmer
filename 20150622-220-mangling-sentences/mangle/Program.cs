using System;

namespace mangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(args[0]);
            var mangler = new Mangler();
            
            var output = mangler.Mangle(args[0]);
            Console.WriteLine(output);
        }
    }
}
