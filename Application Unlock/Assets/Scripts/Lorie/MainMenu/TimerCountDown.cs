using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TimerCountDown : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Text;
    [SerializeField] private MainMenu mainMenu = null;

    public int Duration;
    public int remainingDuration;

    private void Start()
    {
        Beging(Duration);
    }

    public void Beging(int Second)
    {
        remainingDuration = Second;
        StartCoroutine(UpdateTimer());
    }

    private IEnumerator UpdateTimer()
    {
        while (remainingDuration >= 0)
        {
            if (mainMenu.Pause == false)
            {
                Text.text = $"{remainingDuration / 60:00} : {remainingDuration % 60:00}";
                remainingDuration--;
                yield return new WaitForSeconds(1f);
            }
            
            yield return null;

        }
        OnEnd();
    }
    private void OnEnd()
    {
        print("End");
    }
}
