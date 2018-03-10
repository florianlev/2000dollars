using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebutJeu : MonoBehaviour {

	public void lancerJeu()
    {

        GestionLevel.recommencer();

        UnityEngine.SceneManagement.SceneManager.LoadScene(GestionLevel.sceneCourante);


    }
}
