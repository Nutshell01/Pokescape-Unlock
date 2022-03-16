using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CancelButton : MonoBehaviour
{
    [SerializeField] private Canvas CanvasCancel;
    [SerializeField] private Button CurrentButton;

    private void Awake()
    {
        CurrentButton.onClick.AddListener(delegate { SetFalseCanvas(CanvasCancel); });
    }

    public void SetFalseCanvas(Canvas cancelCanvas)
    {
        cancelCanvas.enabled = false;
    }
}
