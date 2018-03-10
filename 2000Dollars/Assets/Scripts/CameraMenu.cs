using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMenu : MonoBehaviour {

    public Camera camera;

    public float vitesse;

    public float vitesseRotation;

    private bool debut = true; 

    private void Awake()
    {

        camera = GetComponent<Camera>();
        vitesse = 2f;
        vitesseRotation = 3f;   

    }

    void Start () {
		
    

	}
	
	void Update () {

        transform.position -= Vector3.left * vitesse * Time.deltaTime;

        if (transform.position.x > 40)
        {
            debut = false;
            vitesse = -vitesse;

        }
        if (transform.position.x > 20)
        {
            transform.Rotate(0, Time.deltaTime * vitesseRotation, 0);
        }

        if (transform.position.x < -4) vitesse = -vitesse;

        if (transform.position.x < 16 && !debut)
        {
            transform.Rotate(0, Time.deltaTime * -vitesseRotation, 0);

        }
    }
}
