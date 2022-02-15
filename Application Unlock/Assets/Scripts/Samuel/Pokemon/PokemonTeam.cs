using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PokemonTeam : MonoBehaviour
{
    [SerializeField] private List<Pokemon> PokemonsInTeam = new List<Pokemon>();
    [SerializeField] private List<Image> ListIcone = new List<Image>();
    [SerializeField] private Sprite DefaultImage;
    public List<Pokemon> pokemonsInTeam { get { return PokemonsInTeam; } set { PokemonsInTeam = value; } }

    public void ShowThePokemonInTeam(Pokemon pokemon)
    {
        for(int i = 0; i<ListIcone.Count; i++)
        {
            if(ListIcone[i].sprite == DefaultImage)
            {
                ListIcone[i].sprite = pokemon.sprite;
                break;
            }
        }
    }
}
