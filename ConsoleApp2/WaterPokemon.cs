using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeGame
{
    internal class WaterPokemon : Pokemon
    {
        public WaterPokemon()
        {
            Type = PokeTypes.Water;
        }

        public override void Attack(Pokemon target)
        {
            //base.Attack(target);
            Bubble();
            Surf();
        }

        public override void Eat(string food)
        {
            Console.WriteLine($"{this.Name} drowned: {food}");
        }

        private void Bubble()
        {
            Console.WriteLine("Blublublub!");
        }

        private void Surf()
        {
            Console.WriteLine("Surfin Bird!");
        }
    }
}
