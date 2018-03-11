using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gestionPV : MonoBehaviour {

    public Text labelpv;


	void Start () {

        if (GestionLevel.vieCourante == 1) labelpv.text = GestionLevel.vieCourante+" canne restante";
        else
        {
            labelpv.text = GestionLevel.vieCourante + " cannes restantes";
        }

		
	}
	
	void Update ()
    {

        if (GestionLevel.vieCourante == 1) labelpv.text = GestionLevel.vieCourante + " canne restante";
        else
        {
            labelpv.text = GestionLevel.vieCourante + " cannes restantes";
        }

    }
}
