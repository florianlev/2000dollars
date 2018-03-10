using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompteARebours : MonoBehaviour
{

    public float compteARebours;

    public Text compteAReboursAffichage;


    // Use this for initialization
    void Start()
    {

        compteARebours = 120f;

        compteAReboursAffichage.text = "Temps restant : " + compteARebours;

    }

    // Update is called once per frame
    void Update()
    {

        compteARebours = compteARebours - Time.timeSinceLevelLoad;

        compteAReboursAffichage.text = "Temps restant : " + compteARebours;


    }


    void finCompteARebours()
    {

        compteAReboursAffichage = "Game Over !";

    }

}

