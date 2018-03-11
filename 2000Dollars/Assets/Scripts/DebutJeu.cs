using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebutJeu : MonoBehaviour {

	public void lancerJeu()
    {

        GestionLevel.recommencer();
        GestionLevel.sceneCourante++;
        UnityEngine.SceneManagement.SceneManager.LoadScene(GestionLevel.sceneCourante);

    }
}
