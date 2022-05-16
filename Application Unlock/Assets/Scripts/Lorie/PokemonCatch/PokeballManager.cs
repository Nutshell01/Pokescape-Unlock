using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PokeballManager : MonoBehaviour
{
    [SerializeField] private Pokeball pokeball = null;
    public bool HasCaught;
    public Canvas canvas;

    public GameObject textBravo;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Pokemon")
        {
            StartCoroutine("CatchPokemon", other.gameObject);
        }
       
    }



  
    IEnumerator CatchPokemon(GameObject Pokemon)
    {
        transform.Translate(Vector3.up * 1, Space.World);
        this.GetComponent<Rigidbody>().useGravity = false;
        this.GetComponent<Rigidbody>().velocity = Vector3.zero;
        Destroy(Pokemon.gameObject);
        yield return new WaitForSeconds(1);
        //pokeball.dragging = false;
        this.GetComponent<Rigidbody>().useGravity = true;
        yield return new WaitForSeconds(1);
        GameObject.FindGameObjectWithTag("MainCamera").transform.LookAt(this.transform);
        GameObject.FindGameObjectWithTag("MainCamera").gameObject.GetComponent<Camera>().fieldOfView = 20f;

        yield return new WaitForSeconds(1);
        transform.Rotate(Vector3.right * 5);
        yield return new WaitForSeconds(0.1f);
        transform.Rotate(-Vector3.right * 5);

        yield return new WaitForSeconds(1);
        transform.Rotate(Vector3.right * 5);
        yield return new WaitForSeconds(0.1f);
        transform.Rotate(-Vector3.right * 5);

        yield return new WaitForSeconds(1);
        transform.Rotate(Vector3.right * 10);
        yield return new WaitForSeconds(0.1f);
        transform.Rotate(-Vector3.right * 10);

        yield return new WaitForSeconds(0.5f);
        textBravo.SetActive(true);

        canvas.enabled = true;
        HasCaught = true;

        GameObject.FindGameObjectWithTag("MainCamera").gameObject.GetComponent<Camera>().fieldOfView = 60f;
        GameObject.FindGameObjectWithTag("MainCamera").gameObject.GetComponent<Camera>().transform.rotation = Quaternion.Euler(0,0,0);
        pokeball.ResetBall();
    }
}
