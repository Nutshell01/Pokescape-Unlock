using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PokemonTeam : MonoBehaviour
{
    [SerializeField] private List<PokemonData> PokemonsInTeam = new List<PokemonData>();
    [SerializeField] private List<GameObject> ListIcone = new List<GameObject>();
    [SerializeField] private Sprite DefaultImage;
    
    public List<PokemonData> pokemonsInTeam { get { return PokemonsInTeam; } set { PokemonsInTeam = value; } }

    public void ShowThePokemonInTeam(PokemonData pokemon)
    {
        for(int i = 0; i<ListIcone.Count; i++)
        {
            if(ListIcone[i].GetComponent<LogInterfacePokemon>().haveAPokemon == false)
            {
                ListIcone[i].GetComponent<LogInterfacePokemon>().ComputeLogInterface(pokemon.sprite, pokemon.arrayTypeOfPokemons[0].typeIcone, pokemon.arrayTypeOfPokemons[1].typeIcone, pokemon.namePokemon, pokemon);
                break;
            }
        }
    }
}
