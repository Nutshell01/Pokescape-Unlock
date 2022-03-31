using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMainMenu : MonoBehaviour
{
    [SerializeField] private Canvas CanvasPenality;
    private void Awake()
    {
        UnityEngine.UI.Button b = gameObject.GetComponent<UnityEngine.UI.Button>();
        b.onClick.AddListener(BackToMainMenu);
    }

    public void BackToMainMenu()
    {
        CanvasPenality.enabled = false;
    }
}
