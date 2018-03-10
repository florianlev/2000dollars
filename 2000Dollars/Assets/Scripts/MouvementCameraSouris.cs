using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementCameraSouris : MonoBehaviour {

    /*public float rotationX;
    public float rotationY;
    public float sensibilite = 80f;*/

    public bool ShowCursor;
    public float Sensibilite;


	// Use this for initialization
	void Start () {

        if(ShowCursor == false)
        {
            Cursor.visible = false;
        }
		
	}
	
	// Update is called once per frame
	void Update () {
        float newRotationY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * Sensibilite;
        float newRotationX = transform.localEulerAngles.x - Input.GetAxis("Mouse Y") * Sensibilite;

        gameObject.transform.localEulerAngles = new Vector3(newRotationX, newRotationY, 0);
        /*rotationX = Input.GetAxis("Mouse Y") * sensibilite;
        rotationY = Input.GetAxis("Mouse X") * sensibilite;

        rotationX = Mathf.Clamp(rotationX, -90, 90);

        transform.rotation = Quaternion.Euler(rotationX, rotationY, 0);*/
	}
}
