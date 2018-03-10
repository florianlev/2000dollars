using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllerMenuPrincipal : MonoBehaviour {

    public GameObject instruction;
    public GameObject menuPrincipal;

    public void allerMenuPrincpal()
    {

        GestionLevel.recommencer();

        instruction.SetActive(false);
        menuPrincipal.SetActive(true);
    }

}
