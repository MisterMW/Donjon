﻿using System;

namespace Donjon
{
    internal abstract class Creature : IDrawable
    {
        public string Symbol => "O";

        public ConsoleColor Color => ConsoleColor.Cyan;
        public Cell Cell { get; set; }
        public Creature(Cell cell)
        {
            Cell = cell;
        }

    }
}