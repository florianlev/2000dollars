using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SensibiliteSouris : MonoBehaviour {


    public Text indicationSensibilite;
    public Slider sliderSensisouris;

   public void modifierSensi()
    {
        GestionLevel.sensibiliteSouris = sliderSensisouris.value;

        indicationSensibilite.text = "Vitesse de la souris :"+(10*sliderSensisouris.value).ToString()+"%";
    }
}
