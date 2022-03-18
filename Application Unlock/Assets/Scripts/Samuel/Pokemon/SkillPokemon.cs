using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class SkillPokemon
{
    [SerializeField] private string NameOfSkill;
    [SerializeField] private Sprite IconeOfSkill;
    [SerializeField] private int NbOfSucces;
    [SerializeField] private int NbOfNextCard;

    public string nameOfSkill => NameOfSkill;
    public Sprite iconeOfSkill => IconeOfSkill;
    public int nbOfNextCard => NbOfNextCard;
    public int nbOfSucces => NbOfSucces;
}
