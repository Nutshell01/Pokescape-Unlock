using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BossManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI NbOfArmsText;
    [SerializeField] private int NbOfArms = 4;
    [SerializeField] private Canvas CurrentCanvas;
    [SerializeField] private Canvas Victory;
    public void ComputeBossDamage()
    {
        NbOfArms--;
        NbOfArmsText.text = NbOfArms.ToString();
        if(NbOfArms != 0)
        {
            CurrentCanvas.enabled = true;
        }
        else
        {
            Victory.enabled = true;
        }
    }
}
