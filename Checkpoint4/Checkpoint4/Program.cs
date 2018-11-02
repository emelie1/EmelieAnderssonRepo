using System;

namespace Checkpoint4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Best movies ever!");

            var movies = new string[] { "Soldier of Domination" };
           

            foreach (var item in movies)
            {
                Console.WriteLine(item);
            }
        }
    }
}
