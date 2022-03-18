using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAddPokemon : MonoBehaviour
{
    [SerializeField] private Canvas CanvasToOpen;
    private void Awake()
    {
        UnityEngine.UI.Button b = gameObject.GetComponent<UnityEngine.UI.Button>();
        b.onClick.AddListener(OpenCanvas);
    }
    private void OpenCanvas()
    {
        CanvasToOpen.enabled = true;
    }
}
