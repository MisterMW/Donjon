using System;

namespace Donjon
{
    class Program
    {
        static void Main(string[] args)
        {
            //  1. starta och köra spelet
            var game = new Game();
            game.Run();

            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();
        }
    }
}
