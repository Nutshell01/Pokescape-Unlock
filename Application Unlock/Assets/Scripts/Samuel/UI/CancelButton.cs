using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CancelButton : MonoBehaviour
{
    public enum ButtonModeQuit
    {
        SetActiveFalse,
        CanvasEnable,
    }
    [SerializeField] private ButtonModeQuit CurrentModeButton = ButtonModeQuit.CanvasEnable;
    [SerializeField] private Canvas CanvasCancel;
    [SerializeField] private Button CurrentButton;
    [SerializeField] private GameObject CancelGameObject;
    private void Awake()
    {
        if(CurrentModeButton == ButtonModeQuit.CanvasEnable)
        {
            CurrentButton.onClick.AddListener(delegate { SetFalseCanvas(CanvasCancel); });
        }
        else
        {
            CurrentButton.onClick.AddListener(delegate { SetFalseGameObject(CancelGameObject); });
        }
        
    }

    public void SetFalseCanvas(Canvas cancelCanvas)
    {
        cancelCanvas.enabled = false;
    }
    public void SetFalseGameObject(GameObject cancelGameObject)
    {
        cancelGameObject.SetActive(false);
    }
}
