using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllerMenuPrincipal : MonoBehaviour {

    public GameObject instruction;
    public GameObject menuPrincipal;
    public GameObject credit;

    public void allerMenuPrincpal()
    {
        print("hello");

        GestionLevel.recommencer();
        
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 0)
        {
            instruction.SetActive(false);
            menuPrincipal.SetActive(true);
            credit.SetActive(false);
        }
        else
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }

    }

}
