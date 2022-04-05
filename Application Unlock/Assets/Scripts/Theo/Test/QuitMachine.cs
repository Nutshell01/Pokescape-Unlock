using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitMachine : MonoBehaviour
{
    private Canvas canvasMachine = null;

    private void Awake()
    {
        canvasMachine = this.GetComponent<Canvas>();
    }

    public void QuitThisMachine()
    {
        canvasMachine.enabled = false;
    }
}
