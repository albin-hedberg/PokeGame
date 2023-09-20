using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeGame
{
    internal class FirePokemon : Pokemon
    {
        public FirePokemon()
        {
            Type = PokeTypes.Fire;
        }

        public override void Attack(Pokemon target)
        {
            //base.Attack(target);
            Ember();
        }

        public override void Eat(string food)
        {
            Console.WriteLine($"{this.Name} burned: {food}");
        }

        private void Ember()
        {
            Console.WriteLine("Burn baby burn!");
        }
    }
}
