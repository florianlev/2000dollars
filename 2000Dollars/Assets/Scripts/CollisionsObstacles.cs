using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionsObstacles : MonoBehaviour {
    private Animator animator;

    // Use this for initialization
    void Start () {

        animator = gameObject.GetComponent<Animator>();
        animator.SetBool("estTomber", false);

    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "obstacleFatale")
        {
            animator.SetBool("estTomber", true);
            //StartCoroutine(attendreFin());

            //GestionLevel.collisonObstacleFatal();



        }
    }

    IEnumerator attendreFin()
    {
        Debug.Log("Before Waiting 2 seconds");
        yield return new WaitForSeconds(2);
        Debug.Log("After Waiting 2 Seconds");
    }
}
