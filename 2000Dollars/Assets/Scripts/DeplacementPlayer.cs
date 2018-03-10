using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementPlayer : MonoBehaviour
{

    private Vector3 deplacement;
    public float vitesse = 10;
    BoxCollider playerCollider;
    private Rigidbody body;
    // Use this for initialization
    void Start()
    {

        playerCollider = gameObject.GetComponent<BoxCollider>();
        body = gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Vector3.right * Time.deltaTime * vitesse);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -(vitesse / 2) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, vitesse * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * vitesse);
        }


    }
}
