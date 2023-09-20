using PokemonCommon.Enums;

namespace PokemonCommon.Pokemons
{
    public class WaterPokemon : Pokemon
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
            Console.WriteLine($"{Name} drowned: {food}");
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
