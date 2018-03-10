using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionLevel : MonoBehaviour {

    private const int SCENE_DEPART = 1;

    private const int VIE_DEPART = 3;


    public static int sceneCourante = SCENE_DEPART;
    public static int vieCourante = VIE_DEPART;

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
            UnityEngine.SceneManagement.SceneManager.LoadScene("Level " + GestionLevel.sceneCourante);

        }

    }

}
