using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionSouris : MonoBehaviour
{

    //public float vitesse = 10f;
    public static float vitesse = 1.25f;
    public GameObject positionFinNiveau;
    private Vector3 startPos;
    private Vector3 TargetPosition;

    public GameObject targetPositionObject;
    private Vector3 positionJoueur;
    private GameObject objetPositionPerso;

    private Animator animator;



    // Use this for initialization
    void Start()
    {

        TargetPosition = positionFinNiveau.transform.position;

        animator = gameObject.GetComponent<Animator>();
        animator.SetBool("estMarcher", true);

    }

    // Update is called once per frame
    void Update()
    {

        //deplacerPersoToutdroit();
        transform.Translate(Vector3.MoveTowards(startPos, -transform.right, vitesse * Time.deltaTime));


        // Fait venir aveugle a la position du chien
        if (Input.GetMouseButtonUp(0))
        {
            animator.SetBool("estMarcher", true);
            positionJoueur = GameObject.Find("Player").transform.position;
            objetPositionPerso = Instantiate(targetPositionObject, positionJoueur, Quaternion.identity);
            objetPositionPerso.name = "objetPositionPerso";
            print(objetPositionPerso.transform.position);
            TargetPosition = objetPositionPerso.transform.position;
            //endPos = TargetPosition + Vector3.forward * distance; 

        }


        // Fait arrêter aveugle
        if (Input.GetMouseButtonUp(1))
        {
            vitesse = 0f;
            animator.SetBool("estMarcher", false);

        }

        //this.transform.Translate(Vector3.MoveTowards(this.transform.position, positionFinNiveau.transform.position, vitesse * Time.deltaTime));

    }

    void OnTriggerEnter(Collider collider)
    {
        Destroy(objetPositionPerso.gameObject);
        TargetPosition = positionFinNiveau.transform.position;
    }


}
