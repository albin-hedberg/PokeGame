using PokemonCommon.Enums;

namespace PokemonCommon.Pokemons
{
    public class DragonPokemon : Pokemon
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
            Console.WriteLine($"{Name} flew away from: {food}");
        }

        private void Fly()
        {
            Console.WriteLine("Flyg, flyga, flög!");
        }
    }
}
