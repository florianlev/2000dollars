using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompteARebours : MonoBehaviour
{

    public float compteARebours;

    public Text compteAReboursAffichage;

    private void Awake()
    {
        compteAReboursAffichage = GetComponent<Text>();
    }

    // Use this for initialization
    void Start()
    {

        compteARebours = 120f;

        int tempsEntier = (int)Math.Ceiling(compteARebours);

        int secondes = tempsEntier % 60;

        int minutes = tempsEntier / 60;

        if ( secondes < 10 ){

            compteAReboursAffichage.text = "Temps restant: 0" + minutes + "m, 0" + secondes+"s";

        }
        else
        {
            compteAReboursAffichage.text = "Temps restant: 0" + minutes + "m, " + secondes + "s";

        }

    }

    // Update is called once per frame
    void Update()
    {

        compteARebours = compteARebours - Time.deltaTime;

        int tempsEntier = (int)Math.Ceiling(compteARebours);

        int secondes = tempsEntier % 60;

        int minutes = tempsEntier / 60;

        if (secondes < 10 ){

            compteAReboursAffichage.text = "Temps restant: 0" + minutes + "m, 0" + secondes + "s";

        }
        else
        {
            compteAReboursAffichage.text = "Temps restant: 0" + minutes + "m, " + secondes + "s";

        }

        if (compteARebours < 0) finCompteARebours();

    }


    void finCompteARebours()
    {

        Cursor.visible = true;
        UnityEngine.SceneManagement.SceneManager.LoadScene(3);
    }

}

