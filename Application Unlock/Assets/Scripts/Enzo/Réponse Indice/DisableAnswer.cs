using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAnswer : MonoBehaviour
{
   
    public void Disable()
    {
        gameObject.GetComponent<Canvas>().enabled = false;
    }
}
