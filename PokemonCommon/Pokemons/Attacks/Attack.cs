using PokemonCommon.Enums;

namespace PokemonCommon.Pokemons.Attacks;

public abstract class Attack
{
    public string Name { get; }
    public double Damage { get; }
    public PokeTypes Type { get; }

    // ctorp (properties) & ctorf (fields)
    protected Attack(string name, double damage, PokeTypes type)
    {
        Name = name;
        Damage = damage;
        Type = type;
    }
}
