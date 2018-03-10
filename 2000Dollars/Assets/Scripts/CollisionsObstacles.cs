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
    }

    private IEnumerator lancerGameOver(float secondes)
    {
        yield return new WaitForSeconds(secondes);
        GestionLevel.collisonObstacleFatal();
    }
}
