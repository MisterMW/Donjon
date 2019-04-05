using System;

namespace Donjon
{
    internal class Game
    {
        public Game()
        {
        }

        private Map map;
        private Hero hero;

        internal void Run()
        {
            Initialize();
            Play();
        }
        private void Initialize()
        {
            map = new Map(width: 10, height: 10);
            Cell heroCell=map.GetCell(4,5);
            hero = new Hero(heroCell);

            map.Creatures.Add(hero);
        }

        private void Play()
        {
            bool gameInProgress = false;
            do
            {
                Draw();
                // Get command from user
                // execute action
                Draw();
                // update objects in game
            } while (gameInProgress);
            Draw();
        }

        private void Draw()
        {
            Console.Clear();
            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    Cell cell = map.GetCell(x, y);
                    IDrawable drawable = cell;

                    foreach (var creature in map.Creatures)
                    {
                        if (creature.Cell == cell)
                        {
                            drawable = creature;
                            break;
                        }
                    }

                    Console.ForegroundColor = cell.Color;
                    Console.Write(" " + drawable.Symbol);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}