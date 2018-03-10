using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionLevel : MonoBehaviour {


    private const int SCENE_DEPART = 1;
    private const int VIE_DEPART = 3;

    public static int sceneCourante = SCENE_DEPART;
    public static int vieCourante = VIE_DEPART;

    //----------- BONUS & MALUS ----------------

    private const int TEMPS_BONUS_LUNETTES = 10;
    private const int TEMPS_BONUS_BALLON = 10;

    private const int TEMPS_MALUS_OS = 3;
    private const int TEMPS_MALUS_VITESSE = 10;
    private const int TEMPS_MALUS_SOURD = 10;

    private float tempsCourantBonusLunettes = 0;
    private float tempsCourantBonusBallon = 0;
    private float tempsCourantMalusOs = 0;
    private float tempsCourantMalusVitesse = 0;
    private float tempsCourantMalusSourd = 0;


    public static bool bonusLunettes = false;
    public static bool bonusBallon = false;

    public static bool malusOs = false;
    public static bool malusVitesse = false;
    public static bool malusSourd = false;

    /**
     * 0 : Aucun bonus/malus actif
     * 1 : Bonus Lunettes
     * 2 : Bonus Ballon
     * 3 : Malus Os
     * 4 : Malus Vitesse
     * 5 : Malus Sourd
     * */
    public static int usActif = 0;


    public static void recommencer()
    {
        vieCourante = VIE_DEPART;
        sceneCourante = SCENE_DEPART;

    }


    public void Update()
    {
        
        if ( vieCourante  < 0)
        {
            sceneCourante = 4;
            UnityEngine.SceneManagement.SceneManager.LoadScene(GestionLevel.sceneCourante);

        }

        switch (usActif)
        {
            case 0:
                    break;

            case 1:

                tempsCourantBonusLunettes -= Time.deltaTime;

                break;

            case 2:
                tempsCourantBonusBallon -= Time.deltaTime;
                break;

            case 3:
                tempsCourantMalusOs -= Time.deltaTime;
                break;

            case 4:
                tempsCourantMalusVitesse -= Time.deltaTime;
                break;

            case 5:
                tempsCourantMalusSourd -= Time.deltaTime;
                break;
        }



    }

    public void declencherBonusLunettes()
    {
        bonusLunettes = true;
        usActif = 1;

        tempsCourantBonusLunettes = TEMPS_BONUS_LUNETTES;

    }

    public void declencherBonusBallon()
    {
        usActif = 2;
        bonusBallon = true;
        tempsCourantBonusBallon = TEMPS_BONUS_BALLON;
    }

    public void declancherMalusOs()
    {
        usActif = 3;
        malusOs = true;
        tempsCourantMalusOs = TEMPS_MALUS_OS;
    }

    public void declancherMalusVitesse()
    {
        usActif = 4;
        malusVitesse = true;
        tempsCourantMalusVitesse = TEMPS_MALUS_VITESSE;
    }

    public void declancherMalusSourd()
    {
        usActif = 5;
        malusSourd = true;
        tempsCourantMalusSourd = TEMPS_MALUS_SOURD;
    }

    public void declancherBonusCanne()
    {
        if (vieCourante < 3) vieCourante++;
    }

    private void gestionBonusLunettes()
    {


    }

    private void gestionBonusBallon()
    {



    }

    private void gestionMalusOs()
    {


    }




}
