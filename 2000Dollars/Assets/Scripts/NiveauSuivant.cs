using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NiveauSuivant : MonoBehaviour {

	public void niveauSuivant()
    {

        GestionLevel.sceneCourante++;

        UnityEngine.SceneManagement.SceneManager.LoadScene(GestionLevel.sceneCourante);

    }
}
