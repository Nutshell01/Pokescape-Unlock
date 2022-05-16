using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockPokemonTeam : MonoBehaviour
{
    [SerializeField] private ButtonAddPokemon button;

    public void UnlockAddPokemon()
    {
        button.UnlockPokemon = true;
        button.Image.color = button.startColor;
    }
}
