using PokeGame;
using PokemonCommon.Characters;
using PokemonCommon.Enums;
using PokemonCommon.Pokemons;

//Console.WriteLine("-------------------------");
Trainer ash = new Trainer();

FirePokemon charmeleon = new FirePokemon();
charmeleon.Name = "Charmeleon";
ash.Catch(charmeleon);

WaterPokemon wartortle = new WaterPokemon();
wartortle.Name = "Wartortle";
ash.Catch(wartortle);

MagmaPokemon magmar = new MagmaPokemon();
magmar.Name = "Magmar";
ash.Catch(magmar);

GrassPokemon bulbasaur = new GrassPokemon();
bulbasaur.Name = "Bulbasaur";
ash.Catch(bulbasaur);

DragonPokemon dragonite = new DragonPokemon();
dragonite.Name = "Dragonite";
ash.Catch(dragonite);

DragonPokemon charizard = new DragonPokemon();
charizard.Name = "Charizard";
charizard.Type = PokeTypes.Fire;
ash.Catch(charizard);

foreach (Pokemon pokemon in ash.PokemonList)
{
    Console.WriteLine(pokemon.Name + " - " + pokemon.Type);
    pokemon.Attack(dragonite);
    pokemon.Eat("Candy");
    Console.WriteLine();
}
