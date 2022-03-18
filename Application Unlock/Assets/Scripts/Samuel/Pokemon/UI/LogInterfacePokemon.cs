using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogInterfacePokemon : MonoBehaviour
{
    [SerializeField] private Image PokemonIcone;
    [SerializeField] private Image Type1;
    [SerializeField] private Image Type2;
    [SerializeField] private TextMeshProUGUI tmpro;

    private PokemonData CurrentPokemon;

    public PokemonData currentPokemon => CurrentPokemon;

    private bool HaveAPokemon;

    public bool haveAPokemon => HaveAPokemon;
    public void ComputeLogInterface(Sprite pokemonIcone, Sprite type1, Sprite type2, string name, PokemonData pokemon)
    {
        PokemonIcone.sprite = pokemonIcone;
        Type1.sprite = type1;
        Type2.sprite = type2;
        tmpro.text = name;
        HaveAPokemon = true;
        CurrentPokemon = pokemon;
    }
}
