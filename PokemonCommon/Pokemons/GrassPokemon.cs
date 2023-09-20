using PokemonCommon.Enums;

namespace PokemonCommon.Pokemons
{
    public class GrassPokemon : Pokemon
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
            Console.WriteLine($"{Name} did questionable things to: {food}");
        }

        private void Bind()
        {
            Console.WriteLine("Kinky BDSM bind!");
        }
    }
}
