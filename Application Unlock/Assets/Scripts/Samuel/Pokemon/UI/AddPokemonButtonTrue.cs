using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Text.RegularExpressions; // needed for Regex

public class AddPokemonButtonTrue : MonoBehaviour
{
    [SerializeField] private PokemonCatchKeypad pokemonCatchKeypad;
    [SerializeField] private PokemonTeam pokemonTeam;
    [SerializeField] private Pokedex pokedex;
    [SerializeField] private StarterManager starterManager;
    [SerializeField] private Canvas UIPenality;
    [SerializeField] private Canvas ThisCanvas;
    [SerializeField] private Pokeball pokeball;
    [SerializeField] private GameObject ButtonValide;

    [SerializeField] private SpawnPokemon spawnPokemon = null;
    //PokemonData selectedPokemon = null;

    private Vector3 toto = new Vector3(0, -0.7f, 4);

    private bool StarterIsAdded;/*

    void OnGUI()
    {
        InputPokemonNumber.text = Regex.Replace(InputPokemonNumber.text, @"[^0-9 ]", "");
    }*/

    private void Awake()
    {
        UnityEngine.UI.Button b = ButtonValide.GetComponent<UnityEngine.UI.Button>();
        b.onClick.AddListener(CheckAndAddPokemon);
    }

    private void CheckAndAddPokemon()
    {
        PokemonData selectedPokemon = null;
        for(int i = 0; i < pokedex.pokemonInThePokedex.Count; i++)
        {
            PokemonData p = pokedex.pokemonInThePokedex[i];
            if (pokemonCatchKeypad.GetOutputValue() == p.numberOfPokemon && p.isInTeam == false)
            {
                selectedPokemon = p;
                break;
            }
        }
        if (selectedPokemon != null)
        {
            if (StarterIsAdded == false)
            {
                CheckIfStartIsAdd(selectedPokemon);
            }
            selectedPokemon.isInTeam = true;
            pokemonTeam.pokemonsInTeam.Add(selectedPokemon);
            pokemonTeam.ShowThePokemonInTeam(selectedPokemon);
            GameObject.Instantiate(selectedPokemon.pokemonModel3D, toto, selectedPokemon.pokemonModel3D.transform.rotation);
            //desactiver le canvas
            ThisCanvas.enabled = false;
            //spawnPokemon.Poke();
            pokeball.initialBall();
            

        }
        else
        {
            UIPenality.enabled = true;
        }
    }

    private void CheckIfStartIsAdd(PokemonData currentPokemon)
    {
        if(currentPokemon == pokedex.starter1)
        {
            starterManager.AddTheStarter(pokedex.starter1, pokedex.starter2, pokedex.pokemonInThePokedex);
            StarterIsAdded = true;
        }
        else if (currentPokemon == pokedex.starter2)
        {
            starterManager.AddTheStarter(pokedex.starter2, pokedex.starter1, pokedex.pokemonInThePokedex);
            StarterIsAdded = true;
        }
    }
}
