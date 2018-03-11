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
                Destroy(GetComponent<Collider>());
                break;

            case "bonusBallon":
                GestionLevel.declencherBonusBallon();
                Destroy(GetComponent<Collider>());
                break;

            case "malusOs":
                GestionLevel.declancherMalusOs();
                Destroy(GetComponent<Collider>());
                break;

            case "malusVitesse":
                GestionLevel.declancherMalusVitesse();
                Destroy(GetComponent<Collider>());
                break;

            case "malusSourd":
                GestionLevel.declancherMalusSourd();
                Destroy(GetComponent<Collider>());
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
