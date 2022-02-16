using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public enum TypeOfPokemon
{
    Fire,
    Normal,
    Poison,
    Psychic,
    Grass,
    Ground,
    Ice,
    Rock,
    Dragon,
    Water,
    Bug,
    Dark,
    Fighting,
    Ghost,
    Steel,
    Flying,
    Electric,
    Fairy
}

[Serializable]
public class TypePokemon
{
    [SerializeField] private Sprite TypeIcone;
    [SerializeField] private TypeOfPokemon typeOfPokemon;
    public Sprite typeIcone => TypeIcone;
}
