using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {



    private void OnCollisionEnter(UnityEngine.Collision collision)
    {

        switch ( collision.collider.tag )
        {
            case "bonusLunettes":
                GestionLevel.declencherBonusLunettes();             
                break;

            case "bonusBallon":
                GestionLevel.declencherBonusBallon();
                break;

            case "malusOs":
                GestionLevel.declancherMalusOs();
                break;

            case "malusVitesse":
                GestionLevel.declancherMalusVitesse();
                break;

            case "malusSourd":
                GestionLevel.declancherMalusSourd();
                break;

            case "obstacleNonFatal":
                GestionLevel.collisionObstacleNonFatal();
                break;

            case "obstacleFatal":
                GestionLevel.collisonObstacleFatal();
                break;

            case "finNiveau":
                GestionLevel.finNiveau();
                break;

                //test
        }

    }



}
