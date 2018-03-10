using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMenu : MonoBehaviour {

    public Camera camera;

    public float vitesse;

    public bool showCursor;

    private void Awake()
    {
        print(Cursor.visible);
        if ( showCursor == false)
        {
            Cursor.visible = true;
        }
        camera = GetComponent<Camera>();
        vitesse = 2f;

    }

    void Start () {
		
    

	}
	
	void Update () {

        transform.position -= Vector3.left * vitesse * Time.deltaTime;


	}
}
