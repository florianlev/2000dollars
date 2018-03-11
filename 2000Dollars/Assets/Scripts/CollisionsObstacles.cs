using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionsObstacles : MonoBehaviour
{
    private Animator animator;

    // Use this for initialization
    void Start()
    {

        animator = gameObject.GetComponent<Animator>();
        animator.SetBool("estTomber", false);
        animator.SetBool("estCollision", false);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "obstacleFatale")
        {
            animator.SetBool("estTomber", true);

            StartCoroutine(lancerGameOver(0.7f));
        }
        if (collider.gameObject.tag == "obstacleNonFatale")
        {
            GestionSouris.arretDeplacement();
            animator.SetBool("estCollision", true);
            StartCoroutine(arretMarche());
        }

     

        if(collider.gameObject.tag == "finNiveau")
        {
            animator.SetBool("estMarcher", false);
            GestionSouris.arretDeplacement();
            animator.SetBool("finNiveau", true);
        }

    }

    private IEnumerator arretMarche()
    {
        yield return new WaitForSeconds(2);
        animator.SetBool("estMarcher", false);
        animator.SetBool("estCollision", false);

    }


    private IEnumerator lancerGameOver(float secondes)
    {
        yield return new WaitForSeconds(secondes);
        GestionLevel.collisonObstacleFatal();
    }




}
