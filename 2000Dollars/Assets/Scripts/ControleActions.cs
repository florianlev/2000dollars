using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleActions : MonoBehaviour
{


    public GameObject cible;
    public static float vitesse = 1.25f;
    private Rigidbody body;
    private Vector3 targetPosition;
    private Animator animator;
    private bool enMouvement;
    private Vector3 positionJoueur;

    void Awake()
    {


    }
    // Use this for initialization
    void Start()
    {

        animator = gameObject.GetComponent<Animator>();
        enMouvement = false;
    }

    // Update is called once per frame
    void Update()
    {
        //float move = Input.GetAxis("Vertical");
        //animator.SetFloat("vitesse", move);

        if ( !GestionLevel.pause)
        {
            targetPosition = positionJoueur;

            if (Input.GetMouseButton(0))
            {
                positionJoueur = GameObject.Find("Player").transform.position;
                setPositionAveugle();
            }
            if (Input.GetMouseButton(1))
            {
                stopAveugle();
            }

            if (enMouvement)
            {
                mouvementAveugle();

            }
        }
    }

    void setPositionAveugle()
    {

        Plane plane = new Plane(Vector3.up, transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float point = 0f;

        if (plane.Raycast(ray, out point))
            targetPosition = ray.GetPoint(point);

        enMouvement = true;
    }

    void mouvementAveugle()
    {


        transform.LookAt(positionJoueur);
        print(positionJoueur);
        transform.position = Vector3.MoveTowards(transform.position, positionJoueur, vitesse * Time.deltaTime);

        if (transform.position == targetPosition)
        {
            enMouvement = false;
        }
    }



    void stopAveugle()
    {

    }
}
