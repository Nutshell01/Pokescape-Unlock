using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokeball : MonoBehaviour
{
    public bool dragging = false;
    private float distance;
    public float ThrowSpeed;
    public float ArchSpeed;
    public float Speed;

    private float OrigineThrowSpeed;
    private float OrigineArchSpeed;
    private float OrigineSpeed;

    private Vector3 origineBall;

    private Rigidbody rb;
    [SerializeField] private Collider coll;
    [SerializeField] private Canvas MainMenuCanvas;
    

    private void Start()
    {
        OrigineThrowSpeed = ThrowSpeed;
        OrigineArchSpeed = ArchSpeed;
        OrigineSpeed = Speed;
        origineBall = transform.position;

        rb = gameObject.GetComponent<Rigidbody>();
    }

    public void OnMouseDown()
    {
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        dragging = true;
        Debug.Log("Down");
    }

    public void OnMouseUp()
    {
        rb.useGravity = true;
        rb.velocity += this.transform.forward * ThrowSpeed;
        rb.velocity += this.transform.up * ArchSpeed;
        dragging = false;

        Speed = 0;
        ThrowSpeed = 0;
        ArchSpeed = 0;

        Debug.Log("Up");
    }

    private void Update()
    {

        if (dragging == true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            transform.position = Vector3.Lerp(this.transform.position, rayPoint, Speed * Time.deltaTime);
        }
    }

    public void ResetBall()
    {
         ThrowSpeed = OrigineThrowSpeed ;
         ArchSpeed = OrigineArchSpeed ;
         Speed = OrigineSpeed;
         transform.position = origineBall;
        rb.useGravity = false;
        coll.enabled = false;

    }

    public void initialBall()
    {
        MainMenuCanvas.enabled = false;
        coll.enabled = true;
    }

}
