using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pokedex : MonoBehaviour
{
    [SerializeField] private List<PokemonData> PokemonsInThePokedex = new List<PokemonData>();
    public List<PokemonData> pokemonInThePokedex => PokemonsInThePokedex;

    public PokemonData starter1 { get => Starter1; set => Starter1 = value; }
    public PokemonData starter2 { get => Starter2; set => Starter2 = value; }

    [SerializeField] private PokemonTeam pokemonTeam;
    [SerializeField] private PokemonData Starter1;
    [SerializeField] private PokemonData Starter2;


    private void Awake()
    {
        for(int i = 0; i<PokemonsInThePokedex.Count; i++)
        {
            PokemonsInThePokedex[i].isInTeam = false;
        }
    }
    private void ChangeBoolInTeam(PokemonData pokemon)
    {
        pokemon.isInTeam = true;
        pokemonTeam.pokemonsInTeam.Add(pokemon);
        pokemonTeam.ShowThePokemonInTeam(pokemon);
    }
}
