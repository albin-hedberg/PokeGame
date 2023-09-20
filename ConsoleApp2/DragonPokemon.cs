using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PokeGame
{
    internal class DragonPokemon : Pokemon
    {
        public DragonPokemon()
        {
            HealthPoints = 200;
            Type = PokeTypes.Dragon;
        }

        public override void Attack(Pokemon target)
        {
            //target.HealthPoints -= 20;
            //Console.WriteLine(this.Name + " Attacks " + target.Name + " (-20hp)");
            Fly();
        }

        public override void Eat(string food)
        {
            Console.WriteLine($"{this.Name} flew away from: {food}");
        }

        private void Fly()
        {
            Console.WriteLine("Flyg, flyga, flög!");
        }
    }
}
