using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SelectedSkillsCanvas : MonoBehaviour
{
    private SkillPokemon CurrentSkill;

    [SerializeField] private Image IconeSkill;
    [SerializeField] private TextMeshProUGUI NameSkillSelected;
    public void ComputeCanvas(SkillPokemon skillPokemon)
    {
        CurrentSkill = skillPokemon;
        NameSkillSelected.text = CurrentSkill.nameOfSkill;
        IconeSkill.sprite = CurrentSkill.iconeOfSkill;
    }
}
