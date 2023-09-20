using PokemonCommon.Enums;

namespace PokemonCommon.Pokemons
{
    public class FirePokemon : Pokemon
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
            Console.WriteLine($"{Name} burned: {food}");
        }

        private void Ember()
        {
            Console.WriteLine("Burn baby burn!");
        }
    }
}
