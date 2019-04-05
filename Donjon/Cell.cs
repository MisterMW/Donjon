using System;
using System.Collections.Generic;

namespace Donjon
{
    internal class Cell : IDrawable
    {
        public string Symbol => "."; // => i stället för { get; }
        public ConsoleColor Color { get; } = ConsoleColor.Cyan;

        public List<Item> Items { get; } = new List<Item>();

        // get the actual Creature from map.Creature.SingleOrDefault(c => c.Cell==this)
        public Creature Creature { get => null; }

    }
}