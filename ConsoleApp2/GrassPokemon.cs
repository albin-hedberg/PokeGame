using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeGame
{
    internal class GrassPokemon : Pokemon
    {
        public GrassPokemon()
        {
            Type = PokeTypes.Grass;
        }
        public override void Attack(Pokemon target)
        {
            Bind();
        }

        public override void Eat(string food)
        {
            Console.WriteLine($"{this.Name} did questionable things to: {food}");
        }

        private void Bind()
        {
            Console.WriteLine("Kinky BDSM bind!");
        }
    }
}
