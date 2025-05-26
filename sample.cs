using System;

namespace SampleNamespace
{
    public class Sample
    {
        public string Greet(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty.", nameof(name));

            return $"Hello, {name}! Welcome to .NET 8.";
        }

        public static void Main(string[] args)
        {
            var sample = new Sample();
            Console.WriteLine(sample.Greet("Developer"));
        }
    }
}