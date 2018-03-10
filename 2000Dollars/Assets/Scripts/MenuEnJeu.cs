using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuEnJeu : MonoBehaviour {

    public GameObject pause;

	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CompteARebours.pause = !CompteARebours.pause;
            Cursor.visible = !Cursor.visible;
            pause.SetActive(CompteARebours.pause);
        }
    }
}
