using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuiviChien : MonoBehaviour {


    public GameObject cible;
    public static float vitesse = 1.25f;
    private Rigidbody body;
    private Vector3 targetPosition;
    private bool enMouvement;


	// Use this for initialization
	void Start () {

        targetPosition = transform.position;
        enMouvement = false;
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetMouseButton(0))
        {
            setPositionAveugle();    
        }
        if(Input.GetMouseButton(1))
        {
            stopAveugle();
        }
	

	}

    void setPositionAveugle()
    {
    }

    void stopAveugle()
    {

    }
}
