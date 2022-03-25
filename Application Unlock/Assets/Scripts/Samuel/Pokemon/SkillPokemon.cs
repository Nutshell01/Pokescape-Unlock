using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class SkillPokemon
{
    [SerializeField] private string NameOfSkill;
    [SerializeField] private Sprite IconeOfSkill;
    [SerializeField] private List<int> NbOfSucces = new List<int>();
    [SerializeField] private List<int> NbOfNextCard = new List<int>();

    public string nameOfSkill => NameOfSkill;
    public Sprite iconeOfSkill => IconeOfSkill;
    public List<int> nbOfNextCard => NbOfNextCard;
    public List<int> nbOfSucces => NbOfSucces;
}
