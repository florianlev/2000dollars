using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuEnJeu : MonoBehaviour {

    public GameObject pause;

	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GestionLevel.pause = !GestionLevel.pause;
            Cursor.visible = !Cursor.visible;
            pause.SetActive(GestionLevel.pause);
        }
    }
}
