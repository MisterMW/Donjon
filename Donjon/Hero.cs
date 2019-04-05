namespace Donjon
{
    internal class Hero :Creature
    {
        public Cell Cell { get; set; }

        public Hero(Cell cell) : base(cell) { }          
        
    }
}