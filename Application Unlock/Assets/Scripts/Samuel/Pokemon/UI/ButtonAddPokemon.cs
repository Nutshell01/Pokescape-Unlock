using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAddPokemon : MonoBehaviour
{
    [SerializeField] private Canvas CanvasToOpen;
    [SerializeField] private Image image;

    private Color StartColor;
    public bool UnlockPokemon;

    public Color startColor { get => StartColor; set => StartColor = value; }
    public Image Image { get => image; set => image = value; }

    private void Awake()
    {
        StartColor = image.color;
        UnityEngine.UI.Button b = gameObject.GetComponent<UnityEngine.UI.Button>();
        b.onClick.AddListener(OpenCanvas);
        if (!UnlockPokemon)
        {
            image.color = StartColor * 0.8f;
        }
    }
    private void OpenCanvas()
    {
        if (UnlockPokemon)
        {
            CanvasToOpen.enabled = !CanvasToOpen.enabled;
            image.color = StartColor;
        }
    }
}
