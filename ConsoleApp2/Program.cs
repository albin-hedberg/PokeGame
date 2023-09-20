using PokeGame;
using PokemonCommon.Characters;
using PokemonCommon.Enums;
using PokemonCommon.Pokemons;

//Console.WriteLine("-------------------------");
Trainer ash = new Trainer();

Pokemon charmeleon = new Pokemon();
charmeleon.Name = "Charmeleon";
ash.Catch(charmeleon);

Pokemon wartortle = new Pokemon();
wartortle.Name = "Wartortle";
ash.Catch(wartortle);

Pokemon magmar = new Pokemon();
magmar.Name = "Magmar";
ash.Catch(magmar);

Pokemon bulbasaur = new Pokemon();
bulbasaur.Name = "Bulbasaur";
ash.Catch(bulbasaur);

Pokemon dragonite = new Pokemon();
dragonite.Name = "Dragonite";
ash.Catch(dragonite);

Pokemon charizard = new Pokemon();
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
