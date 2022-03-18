using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillPokemonDataCanvas : MonoBehaviour
{
    [SerializeField] private SkillPokemon CurrentSkillPokemonCanvas;
    public SkillPokemon currentSkillPokemonCanvas { get { return CurrentSkillPokemonCanvas; }set { CurrentSkillPokemonCanvas = value; } }
}
