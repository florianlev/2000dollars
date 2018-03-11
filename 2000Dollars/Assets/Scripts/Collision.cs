using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

    private Animator animator;


    public void Awake()
    {
     
    }

    public void Start()
    {
        animator = gameObject.GetComponent<Animator>();

    }

    private void OnTriggerEnter(Collider collider)
    {

        switch ( collider.gameObject.tag )
        {
            case "bonusLunettes":
                GestionLevel.declencherBonusLunettes();
                Destroy(GetComponent<Collider>());
                break;

            case "bonusHelice":
                print("test");
                GestionLevel.declencherBonusBallon();
                animator.SetBool("enVol", true);
                Destroy(GameObject.Find("Bonus_helice"));
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
