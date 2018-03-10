using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfficherInstruction : MonoBehaviour
{

    public GameObject instruction2;
    public GameObject menuPrincipal2;

    public void allerInstruction()
    {

        GestionLevel.recommencer();

        instruction2.SetActive(true);
        menuPrincipal2.SetActive(false);
    }

}
