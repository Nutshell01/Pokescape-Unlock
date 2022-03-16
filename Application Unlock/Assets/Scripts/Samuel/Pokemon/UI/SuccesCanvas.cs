using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SuccesCanvas : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI NbOfCard;

    public void ComputeNbOfCard(string nbOfCard)
    {
        NbOfCard.text = nbOfCard;
    }
}

