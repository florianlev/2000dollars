using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfficherCredit : MonoBehaviour {

    public GameObject credit2;
    public GameObject menuPrincipal2;

    public void allerCredit()
    {

        GestionLevel.recommencer();

        print("hello");
        credit2.SetActive(true);
        menuPrincipal2.SetActive(false);
    }
}
