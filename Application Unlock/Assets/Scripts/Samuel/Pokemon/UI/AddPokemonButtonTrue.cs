using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Text.RegularExpressions; // needed for Regex

public class AddPokemonButtonTrue : MonoBehaviour
{
    [SerializeField] private TMP_InputField InputPokemonNumber;
    [SerializeField] private PokemonTeam pokemonTeam;
    [SerializeField] private Pokedex pokedex;

    void OnGUI()
    {
        InputPokemonNumber.text = Regex.Replace(InputPokemonNumber.text, @"[^0-9 ]", "");
    }

    private void Awake()
    {
        UnityEngine.UI.Button b = gameObject.GetComponent<UnityEngine.UI.Button>();
        b.onClick.AddListener(CheckAndAddPokemon);
    }

    private void CheckAndAddPokemon()
    {
        for(int i = 0; i < pokedex.pokemonInThePokedex.Count; i++)
        {
            PokemonData p = pokedex.pokemonInThePokedex[i];
            if (int.Parse(InputPokemonNumber.text) == p.numberOfPokemon && p.isInTeam == false)
            {
                p.isInTeam = true;
                pokemonTeam.pokemonsInTeam.Add(p);
                pokemonTeam.ShowThePokemonInTeam(p);
                break;
            }
        }
    }
}
