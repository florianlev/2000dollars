using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMenu : MonoBehaviour {

    public Camera camera;

    public float vitesse;

    private void Awake()
    {

        camera = GetComponent<Camera>();
        vitesse = 20f;

    }

    void Start () {
		
    

	}
	
	void Update () {

        transform.position += Vector3.forward * vitesse * Time.deltaTime;


	}
}
