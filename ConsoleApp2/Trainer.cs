using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeGame
{
    internal class Trainer
    {
        List<Pokemon> _pokemonList = new List<Pokemon>();
        public List<Pokemon> PokemonList
        {
            get { return _pokemonList; }
            set { _pokemonList = value; }
        }

        public void Catch(Pokemon pokemon)
        {
            _pokemonList.Add(pokemon);
        }

        public void Release(Pokemon pokemon)
        {
            if (_pokemonList.Contains(pokemon))
            {
                _pokemonList.Remove(pokemon);
            }
        }

        // Detta är en statisk metod. Statiska metoder anropas via typen och inte via objekt.
        public static void Greeting() 
        {
            Console.WriteLine("Hi!");
        }
    }
}
