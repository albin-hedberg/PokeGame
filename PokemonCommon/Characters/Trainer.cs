﻿using PokemonCommon.Pokemons;

namespace PokemonCommon.Characters
{
    public class Trainer
    {
        // prop
        //public List<Pokemon> PokemonList { get; set; } = new List<Pokemon>();

        List<Pokemon> _pokemonList = new List<Pokemon>();
        public List<Pokemon> PokemonList
        {
            get { return _pokemonList; }
            set { _pokemonList = value; }
        }

        public void Catch(Pokemon pokemon)
        {
            _pokemonList.Add(pokemon);
            //PokemonList.Add(pokemon);
        }

        public void Release(Pokemon pokemon)
        {
            if (_pokemonList.Contains(pokemon))
            {
                _pokemonList.Remove(pokemon);
            }
            //if (PokemonList.Contains(pokemon))
            //{
            //    PokemonList.Remove(pokemon);  // Remove returnerar true/false
            //}
        }

        // Detta är en statisk metod. Statiska metoder anropas via typen och inte via objekt.
        public static void Greeting()
        {
            Console.WriteLine("Hi!");
        }
    }
}
