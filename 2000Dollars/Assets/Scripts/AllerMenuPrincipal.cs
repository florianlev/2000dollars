using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllerMenuPrincipal : MonoBehaviour {

    public GameObject instruction;
    public GameObject menuPrincipal;

    public void allerMenuPrincpal()
    {

        GestionLevel.recommencer();
        
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 0)
        {
            instruction.SetActive(false);
            menuPrincipal.SetActive(true);
        }
        else
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }

    }

}
