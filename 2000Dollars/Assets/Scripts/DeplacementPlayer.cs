using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementPlayer : MonoBehaviour
{

    private Vector3 deplacement;
    public float speed = 10;
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
        deplacement = Vector3.zero;


        if (Input.GetKey(KeyCode.A))
        {
            deplacement += -transform.right;
        }
        if (Input.GetKey(KeyCode.S))
        {
            deplacement += -transform.forward;
        }
        if (Input.GetKey(KeyCode.W))
        {
            deplacement += transform.forward;
        }
        if (Input.GetKey(KeyCode.D))
        {
            deplacement += transform.right;
        }

        transform.position += deplacement * speed * Time.deltaTime;

    }
}
