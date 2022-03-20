using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokeballManager : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Pokemon")
        {
            StartCoroutine("CatchPokemon", other.gameObject);
        }
    }

    IEnumerator CatchPokemon(GameObject Pokemon)
    {
        return null;
    }
}
