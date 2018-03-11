using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuEnJeu : MonoBehaviour {

    public GameObject pause;

    public Text affichageVie;

    private void Start()
    {
    }

    void Update () {

        affichageVie.text = GestionLevel.vieCourante + " cannes restantes";

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GestionLevel.pause = !GestionLevel.pause;
            Cursor.visible = !Cursor.visible;
            pause.SetActive(GestionLevel.pause);



        }
    }
}
