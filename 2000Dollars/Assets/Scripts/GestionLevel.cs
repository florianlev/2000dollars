using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionLevel : MonoBehaviour
{

    /**
     *   INDEX DE SCENE
     * Menu début de jeu___0
     * Niveau 1____________1
     * Niveau 2____________2
     * Niveau 3____________3
     * Fin de niveau_______4
     * Game Over___________5
     * 
     * */

    //----------- GESTION DU TEMPS --------------------------

    public static bool pause = false;

    public static float[] tableau_temps_lvl = new float[] { 120f, 180f, 210f };

    //----------- SENSIBILITE SOURIS --------------
    public static float sensibiliteSouris = 5;

    private const int SCENE_DEPART = 0;
    private const int VIE_DEPART = 3;
    private const float VITESSE = 1.25f;
    private const float PORTE_AUDITION = 2000f;

    //----------- GESTION DES SCENES --------------------

    public static int sceneCourante = SCENE_DEPART;

    //------------ CARACTERISTIQUES AVEUGLE---------------

    public static int vieCourante = VIE_DEPART;
    public static float vitesseCourante = VITESSE;
    public static float porteeAuditionCourante = PORTE_AUDITION;

    //------------ CARACTERISTIQUES CHIEN---------------


    //----------- BONUS & MALUS ----------------

    private const int TEMPS_BONUS_LUNETTES = 10;
    private const int TEMPS_BONUS_BALLON = 10;

    private const int TEMPS_MALUS_OS = 3;
    private const int TEMPS_MALUS_VITESSE = 10;
    private const int TEMPS_MALUS_SOURD = 10;

    private static float tempsCourantBonusLunettes = 0;
    private static float tempsCourantBonusBallon = 0;
    private static float tempsCourantMalusOs = 0;
    private static float tempsCourantMalusVitesse = 0;
    private static float tempsCourantMalusSourd = 0;


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


    //------------- DEBUT NIVEAU ----------------------

    

    //-------------- UPDATE ---------------------------
    public void Start()
    {

    }
    public void Update()
    {


        if (vieCourante <= 0)
        {
            print("test");
            sceneCourante = 4;
            UnityEngine.SceneManagement.SceneManager.LoadScene(3);
            Cursor.visible = !Cursor.visible;
        }


        switch (usActif)
        {
            case 0:
                break;

            case 1:

                gestionBonusLunettes();
                break;

            case 2:
                gestionBonusBallon();
                break;

            case 3:
                gestionMalusOs();
                break;

            case 4:
                gestionMalusVitesse();
                break;

            case 5:
                gestionMalusSourd();
                break;
        }

    }

    
    public static void recommencer()
    {
        vieCourante = VIE_DEPART;
        sceneCourante = SCENE_DEPART;

    }
    //------------- DECLENCHEMENT DES US --------------------
    public static void declencherBonusLunettes()
    {
        bonusLunettes = true;
        usActif = 1;
        tempsCourantBonusLunettes = TEMPS_BONUS_LUNETTES;

    }

    public static void declencherBonusBallon()
    {

        
        usActif = 2;
        bonusBallon = true;
        tempsCourantBonusBallon = TEMPS_BONUS_BALLON;
    }

    public static void declancherMalusOs()
    {
        usActif = 3;
        malusOs = true;
        tempsCourantMalusOs = TEMPS_MALUS_OS;
    }

    public static void declancherMalusVitesse()
    {
        usActif = 4;
        malusVitesse = true;
        tempsCourantMalusVitesse = TEMPS_MALUS_VITESSE;
        vitesseCourante = 40f;
    }

    public static void declancherMalusSourd()
    {
        usActif = 5;
        malusSourd = true;
        tempsCourantMalusSourd = TEMPS_MALUS_SOURD;
        porteeAuditionCourante = 1000f;
    }

    public static void declancherBonusCanne()
    {
        if (vieCourante < 3) vieCourante++;
    }

    //-------------- COLLISION ---------------------------

    public static void collisionObstacleNonFatal()
    {
        vieCourante -= 1;

    }

    public static void collisonObstacleFatal()
    {
        vieCourante = 0;

    }

    //--------------- FIN DU NIVEAU ------------------------

    public static void finNiveau()
    {

        vitesseCourante = 0f;
        usActif = 0;

    }


    //------------- GESTION DES US -------------------------

    private void gestionBonusLunettes()
    {
        tempsCourantBonusLunettes -= Time.deltaTime;

        if (tempsCourantBonusLunettes < 0)
        {
            bonusLunettes = false;
            tempsCourantBonusLunettes = 0f;
            usActif = 0;
        }

    }

    private void gestionBonusBallon()
    {

        tempsCourantBonusBallon -= Time.deltaTime;

        if (tempsCourantBonusBallon < 0)
        {
            bonusBallon = false;
            tempsCourantBonusBallon = 0f;
            usActif = 0;
        }

    }

    private void gestionMalusOs()
    {
        tempsCourantMalusOs -= Time.deltaTime;

        if (tempsCourantMalusOs < 0)
        {
            malusOs = false;
            tempsCourantMalusOs = 0f;
            usActif = 0;
        }
    }

    private void gestionMalusVitesse()
    {
        tempsCourantMalusVitesse -= Time.deltaTime;

        if (tempsCourantMalusVitesse < 0)
        {
            malusVitesse = false;
            tempsCourantMalusVitesse = 0f;
            usActif = 0;
            vitesseCourante = 20f;
        }
    }

    private void gestionMalusSourd()
    {
        tempsCourantMalusSourd -= Time.deltaTime;

        if (tempsCourantMalusSourd < 0)
        {
            malusSourd = false;
            tempsCourantMalusSourd = 0f;
            usActif = 0;
            porteeAuditionCourante = 2000f;

        }
    }
}
